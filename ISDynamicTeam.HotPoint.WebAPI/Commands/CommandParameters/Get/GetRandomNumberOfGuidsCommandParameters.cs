namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public class GetRandomNumberOfGuidsCommandParameters : CommandParameters
    {
       
        private int count;

        public int Count { get => count; set => count = value; }
      
    }
}
