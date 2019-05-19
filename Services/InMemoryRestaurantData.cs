using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhidhaLagche.Models;

namespace KhidhaLagche.Services
{
    //public class InMemoryRestaurantData : IRestaurantData
    //{
    //    private List<Restaurant> _restaurants;

    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant{Id=1, Name="Asif's restaurant"},
    //            new Restaurant{Id=2, Name="Asif's restaurant2"},
    //            new Restaurant{Id=3, Name="Asif's restaurant3"},
    //            new Restaurant{Id=4, Name="Asif's restaurant4"},
    //        };
    //    }

    //    public Restaurant Add(Restaurant newRestaurant)
    //    {
    //        newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(newRestaurant);

    //        return newRestaurant;
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(r => r.Name);
    //    }
    //}
}
