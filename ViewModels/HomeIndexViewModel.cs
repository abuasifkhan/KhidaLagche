using System.Collections.Generic;
using KhidhaLagche.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhidhaLagche.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}