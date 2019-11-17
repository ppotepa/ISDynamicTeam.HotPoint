using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Handlers
{
    public abstract class CommandHandler : ICommandHandler, IDisposable
    {

        public abstract ICommandResult Handle();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }
        bool disposed = false;
        public CommandHandler(ICommand command)
        {
            this.command = command;
        }

        protected ICommand command;
    }
}
