using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Functions
{
    public class CommandHandlers
    {
        public static Func<ICommand, ICommandResult> GetRandomNumberCommandHandler = (ICommand command) =>
        {
            return new GetRandomNumberCommandResult();
        };

        public static Func<ICommand, ICommandResult> GetNearbyPlacesHandler = (ICommand command) =>
        {
            return new GetRandomNumberCommandResult();
        };

        public static Func<ICommand, ICommandResult> GetRandomNumberOfGuidsHandler = (ICommand command) =>
        {
            return new GetRandomNumberOfGuidsCommandResult();
        };
    }
}
