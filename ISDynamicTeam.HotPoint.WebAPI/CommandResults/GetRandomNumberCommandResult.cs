using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetRandomNumberCommandResult : CommandResult
    {
        public int RandomNumber { get; private set; } = new Random().Next(100);
    }
}
