using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetNearbyPlacesCommandResult : CommandResult
    {
        public string[] places = {
            "Sfinx", "McDonald",
        };
    }
}
