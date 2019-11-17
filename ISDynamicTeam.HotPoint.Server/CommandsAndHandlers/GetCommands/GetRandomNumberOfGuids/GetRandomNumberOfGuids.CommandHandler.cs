using ISDynamicTeam.HotPoint.Server.Commands;
using System.Linq;

namespace ISDynamicTeam.HotPoint.Server.Handlers
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
