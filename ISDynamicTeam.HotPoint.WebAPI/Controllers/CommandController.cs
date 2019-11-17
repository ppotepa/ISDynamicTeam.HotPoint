using ISDynamicTeam.HotPoint.WebAPI.Commands;
using ISDynamicTeam.HotPoint.WebAPI.Const;
using ISDynamicTeam.HotPoint.WebAPI.Extensions;
using ISDynamicTeam.HotPoint.WebAPI.Handlers;
using ISDynamicTeam.HotPoint.WebAPI.Handlers.Get;
using ISDynamicTeam.HotPoint.WebAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        private static IDictionary<Type, Type> CommandRouter =

            new Dictionary<Type, Type>
            {
                 {  typeof(GetRandomNumberOfGuidsCommand), typeof(GetRandomNumberOfGuidsCommandHandler)},
            };


        [HttpGet]
        [Route("execute")]
        public async Task<object> ExecuteCommand(object command)
        {
            JObject cmd = ((JObject)command);

            string targetName = cmd.GetValue("CommandName").Value<string>();

            Type targetCommandType = CommandInstanceHelper.GetTypeByName(targetName);
            object deserializedCommand = cmd.ToObject(targetCommandType);
            Type routedType = CommandRouter[targetCommandType];

            return await Task.Run(() =>
            {
                CommandHandler handler = (CommandHandler)Activator.CreateInstance(routedType, new object[] { (ICommand)deserializedCommand });                
                ICommandResult commandResult = handler.Handle();
                handler.Dispose();
                if (((Command)deserializedCommand).CompressResult)
                {
                    byte[] byteArray = commandResult.ToByteArray();
                    return ObjectCompressor.Compress(byteArray);
                }
                return commandResult;
            });
        }

    }
}
