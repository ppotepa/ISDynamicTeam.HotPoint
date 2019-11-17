using System;

namespace ISDynamicTeam.HotPoint.Common
{
    [Serializable]
    public class RestaurantModel
    {
        private string name;
        private Location location;

        public string Name { get => name; set => name = value; }
        public Location Location { get => location; set => location = value; }
        public RestaurantModel(string Name, Location Location)
        {
            this.Name = Name;
            this.Location = Location;
        }

    }
}
