using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhidhaLagche.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhidhaLagche.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public string CurrentGreeting { get; set; }

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet(string name)
        {
            CurrentGreeting = $"{name}, {_greeter.GetGreetingMessage()}";
        }
    }
}