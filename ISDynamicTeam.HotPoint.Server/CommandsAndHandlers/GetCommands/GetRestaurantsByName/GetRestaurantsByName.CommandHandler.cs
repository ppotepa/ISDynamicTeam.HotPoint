using ISDynamicTeam.HotPoint.Common;
using ISDynamicTeam.HotPoint.DataLayer.DBAccess;
using ISDynamicTeam.HotPoint.Server.Commands;
using System.Collections.Generic;
using System.Linq;

namespace ISDynamicTeam.HotPoint.Server.Handlers
{
    public class GetRestaurantsByNameCommandHandler : GetCommandHandler
    {
        public override ICommandResult Handle()
        {
            GetRestaurantsByNameCommand _command = (GetRestaurantsByNameCommand)command; ;
            GetRestaurantsByNameCommandParameters _params = _command.CommandParameters;

            string letters = _params.Name;

            List<RestaurantModel> queryResult = FakeDB.Restaurants.Where(r => r.Name.Contains(letters)).ToList();
            GetRestaurantsByNameCommandResult result = new GetRestaurantsByNameCommandResult(queryResult);
            return result;
        }

        public GetRestaurantsByNameCommandHandler(ICommand command) : base(command) { }
    }
}
