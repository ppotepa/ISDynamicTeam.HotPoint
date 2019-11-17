namespace ISDynamicTeam.HotPoint.Server.Commands
{
    public class GetRestaurantsByNameCommandParameters : CommandParameters
    {
       
        private string name;

        public string Name { get => name; set => name = value; }
      
    }
}
