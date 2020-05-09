using Microsoft.AspNetCore.Mvc;
using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food
{
    public class HomeController
    {
        //public string Index()
        //{
        //    return "hello form Home Controlelr";
        //}

        public IActionResult Index()
        {
            var model = new Resturant { Id = 1, Name = "Pepe's Pizza" };
            return new ObjectResult(model);
        }
    }
}
