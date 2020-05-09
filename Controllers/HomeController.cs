using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ode2Food.Models;
using ode2Food.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food
{
    public class HomeController : Controller
    {
        private IResturant _resturant { get; set; }
        public HomeController(IResturant resturant)
        {
            _resturant = resturant;
        }
        //public string Index()
        //{
        //    return "hello form Home Controlelr";
        //}

        //public IActionResult Index()
        //{
        //    var model = new Resturant { Id = 1, Name = "Pepe's Pizza" };
        //    return View(model);
        //    //return new ObjectResult(model);
        //}

        public IActionResult Index()
        {
            var model = _resturant.GetAll();
            return View(model);
            //return new ObjectResult(model);
        }
    }
}
