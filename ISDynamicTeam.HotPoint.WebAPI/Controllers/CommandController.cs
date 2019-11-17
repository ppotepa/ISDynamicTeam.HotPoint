using ISDynamicTeam.HotPoint.Server;
using ISDynamicTeam.HotPoint.Server.Commands;
using ISDynamicTeam.HotPoint.Server.Extensions;
using ISDynamicTeam.HotPoint.Server.Handlers;
using ISDynamicTeam.HotPoint.Utils;
using ISDynamicTeam.HotPoint.WebAPI.Routers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        private static CommandRouter CommandRouter = new CommandRouter();
        public static void InitializeRouter()
        {
            CommandRouter
                .Register<ICommand, ICommandHandler>(typeof(GetRandomNumberOfGuidsCommand), typeof(GetRandomNumberOfGuidsCommandHandler))
                .Register<ICommand, ICommandHandler>(typeof(GetRestaurantsByNameCommand),   typeof(GetRestaurantsByNameCommandHandler));
        }

        [HttpGet]
        [Route("execute")]
        public async Task<object> ExecuteCommand(object command)
        {
            JObject cmd = command as JObject;
            string commandName = cmd.GetValue("CommandName").Value<string>();

            Type commandType =  CommandRouter.GetCommandType(commandName);
            Type commandHandler = CommandRouter.GetHandler<CommandHandler>(commandName);

            object deserializedCommand = cmd.ToObject(commandType);
            return await Task.Run(() =>
            {
                CommandHandler handler = Activator.CreateInstance(commandHandler, new object[] { deserializedCommand }) as CommandHandler;
                ICommandResult commandResult = handler.Handle();
                handler.Dispose();
                if ((deserializedCommand as Command).CompressResult)
                {
                    byte[] byteArray = commandResult.ToByteArray();
                    object compressed = ObjectCompressor.Compress(byteArray);
                    return compressed;
                }
                return commandResult;
            });
        }

    }
}
