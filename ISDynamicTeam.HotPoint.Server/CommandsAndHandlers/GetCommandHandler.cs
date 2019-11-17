using ISDynamicTeam.HotPoint.Server.Commands;
using System;

namespace ISDynamicTeam.HotPoint.Server.Handlers
{
    public abstract class GetCommandHandler : CommandHandler
    {
        public GetCommandHandler(ICommand command) : base(command)
        {

        }

        public override ICommandResult Handle()
        {
            throw new NotImplementedException();
        }
    }
}
