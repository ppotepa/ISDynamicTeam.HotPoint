using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Handlers
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
