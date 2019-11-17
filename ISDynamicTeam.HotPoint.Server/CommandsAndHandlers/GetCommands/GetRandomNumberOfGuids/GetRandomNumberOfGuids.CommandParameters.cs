namespace ISDynamicTeam.HotPoint.Server.Commands
{
    public class GetRandomNumberOfGuidsCommandParameters : CommandParameters
    {
       
        private int count;

        public int Count { get => count; set => count = value; }
      
    }
}
