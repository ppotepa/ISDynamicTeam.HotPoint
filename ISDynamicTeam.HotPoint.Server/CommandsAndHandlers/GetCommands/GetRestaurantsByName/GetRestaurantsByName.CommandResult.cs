using ISDynamicTeam.HotPoint.Common;
using System;
using System.Collections.Generic;

namespace ISDynamicTeam.HotPoint.Server.Commands
{
    [Serializable]
    public class GetRestaurantsByNameCommandResult : CommandResult
    {

        public List<RestaurantModel> restaurants { get; private set; }
        public GetRestaurantsByNameCommandResult(List<RestaurantModel> restaurants) {
            this.restaurants = restaurants;
        }
    };
}
