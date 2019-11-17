using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetRandomNumberCommand : ICommand
    {
        public int RandomNumber { get; private set; } = new Random().Next(int.MaxValue);
        public GetRandomNumberCommand() {
           
        }
    }
}
