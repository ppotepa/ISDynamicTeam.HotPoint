using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetRandomNumberCommandResult : CommandResult
    {
        public int RandomNumber { get; private set; } = new Random().Next(100);
    }
}
