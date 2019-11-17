using ISDynamicTeam.HotPoint.Server.Commands;
using System;

namespace ISDynamicTeam.HotPoint.Server.Handlers
{

    public interface ICommandHandler { ICommandResult Handle(); }

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
