using ISDynamicTeam.HotPoint.Server.Commands;
using ICommand = ISDynamicTeam.HotPoint.Server.Commands.ICommand;
namespace ISDynamicTeam.HotPoint.Server
{
    public class GetRestaurantsByNameCommand : Command
    {
        public GetRestaurantsByNameCommand() {
           
        }

        public new GetRestaurantsByNameCommandParameters CommandParameters { get; set; }
    }
}
