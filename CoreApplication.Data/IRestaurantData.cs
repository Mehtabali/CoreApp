using CoreApplication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Pizza", Cusine = Cusine.Indian, Location = "Hyderabad"},
                new Restaurant{Id = 2, Name = "Hot Dog", Cusine = Cusine.Mexican, Location = "Maxico"},
                new Restaurant{Id = 3, Name = "Sandwich", Cusine = Cusine.Italian, Location = "Italy"}
            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
