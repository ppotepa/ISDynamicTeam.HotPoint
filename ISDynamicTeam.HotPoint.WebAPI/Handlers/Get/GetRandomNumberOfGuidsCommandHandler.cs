using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISDynamicTeam.HotPoint.WebAPI.Commands;

namespace ISDynamicTeam.HotPoint.WebAPI.Handlers.Get
{
    public class GetRandomNumberOfGuidsCommandHandler : GetCommandHandler
    {
        public override ICommandResult Handle()
        {
            GetRandomNumberOfGuidsCommand _command = (GetRandomNumberOfGuidsCommand)command; ;
            GetRandomNumberOfGuidsCommandParameters _params = _command.CommandParameters;
            GetRandomNumberOfGuidsCommandResult result = GetRandomNumberOfGuidsCommandResult.GetCount
            (
                _params.Count
            );

            return result;
        }

        public GetRandomNumberOfGuidsCommandHandler(ICommand command) : base(command) { }
    }
}
