using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    [Serializable]
    public partial class Command : ICommand, IDisposable
    {
        private Guid id = Guid.NewGuid();
        private DateTime timeStamp = DateTime.Now;
        private string commandName;

        public Guid Id { get => id; private set => id = value; }
        public DateTime TimeStamp { get => timeStamp; private set => timeStamp = value; }
        public string CommandName { get => commandName; set => commandName = value; }
        public bool CompressResult { get => compressResult; set => compressResult = value; }

        public Command()
        {

        }

        public CommandParameters CommandParameters { get; set; }

       

        bool disposed = false;
        private bool compressResult;

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
    }
}
