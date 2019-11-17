using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class Command : ICommand
    {
        private Guid id = Guid.NewGuid();
        private DateTime timeStamp = DateTime.Now;

        public Guid Id { get => id; private set => id = value; }
        public DateTime TimeStamp { get => timeStamp; private set => timeStamp = value; }


        public Command()
        {
            
        }

       
    }
}
