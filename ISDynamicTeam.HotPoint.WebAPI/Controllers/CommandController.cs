using ISDynamicTeam.HotPoint.WebAPI.Commands;
using ISDynamicTeam.HotPoint.WebAPI.Const;
using ISDynamicTeam.HotPoint.WebAPI.Functions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        private static IDictionary<Type, Func<ICommand, ICommandResult>> CommandRouter =

            new Dictionary<Type, Func<ICommand, ICommandResult>>
            {
                 { typeof(GetRandomNumberCommand),  CommandHandlers.GetRandomNumberCommandHandler },
                 { typeof(GetNearbyPlacesCommand),  CommandHandlers.GetNearbyPlacesHandler },
                 { typeof(GetRandomNumberOfGuidsCommand),  CommandHandlers.GetRandomNumberOfGuidsHandler },
            };

        // GET api/values
        [HttpPost]
        [Route("execute")]
        public async Task<ICommandResult> ExecuteCommand(string commandName)
        {
            Command targetCommand = CommandActivator.FromCommandName(commandName);
            var targetCommandType = targetCommand.GetType();
            return await Task.Run(() => {  return  CommandRouter[targetCommandType](targetCommand); });
        }
    }
}
