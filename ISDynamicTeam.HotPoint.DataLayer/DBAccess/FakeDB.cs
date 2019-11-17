using ISDynamicTeam.HotPoint.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISDynamicTeam.HotPoint.DataLayer.DBAccess
{
    public static class FakeDB
    {
        public static List<RestaurantModel> Restaurants = new List<RestaurantModel>() {
            new RestaurantModel("Sphinx", new Location(){ Latitude = 50.01, Longitude = 50.003}),
            new RestaurantModel("MCDonald",  new Location(){ Latitude = 51.01, Longitude = 53.103}),
            new RestaurantModel("BurgerKing",  new Location(){ Latitude = 52.35, Longitude = 50.003}),
            new RestaurantModel("KebabKing",  new Location(){ Latitude = 50.01, Longitude = 51.023}),
            new RestaurantModel("SapkoKebab",  new Location(){ Latitude = 53.21, Longitude = 52.103}),
            new RestaurantModel("PizzaExpress",  new Location(){ Latitude = 53.01, Longitude = 50.103}),
            new RestaurantModel("Dominos",  new Location(){ Latitude = 52.11, Longitude = 50.1113}),
        };
    }
}
