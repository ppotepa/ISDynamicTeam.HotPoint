using ISDynamicTeam.HotPoint.WebAPI.Helpers;
using System;
using System.Collections.Generic;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    [Serializable]
    public class GetRandomNumberOfGuidsCommandResult : CommandResult
    {
        public IEnumerable<Guid> Guids { get; set; } = new List<Guid>();
        public static GetRandomNumberOfGuidsCommandResult GetCount(int count) {

            using (GetRandomNumberOfGuidsCommandResult commandResult = new GetRandomNumberOfGuidsCommandResult()) {
                commandResult.Guids = GUIDHelper.GetNumberOfGuid(count);
                return commandResult;
            }
            
        }
    }
}
