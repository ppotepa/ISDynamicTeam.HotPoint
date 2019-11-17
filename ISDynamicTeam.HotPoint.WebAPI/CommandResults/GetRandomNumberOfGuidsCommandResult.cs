using ISDynamicTeam.HotPoint.WebAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetRandomNumberOfGuidsCommandResult : CommandResult
    {
        public IEnumerable<Guid> List = GUIDHelper.GetRandomNumberOfGuids();
    }
}
