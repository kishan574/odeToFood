using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ode2Food.Models;
using ode2Food.Services;
using ode2Food.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food
{
    public class HomeController : Controller
    {
        private IResturant _resturant;
        private IGreeter _greetre;

        public HomeController(IResturant resturant,
                              IGreeter greeter)
        {
            _resturant = resturant;
            _greetre = greeter;
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
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel();
            homeIndexViewModel.Resturants = _resturant.GetAll();
            homeIndexViewModel.Greeter = _greetre.greetingsOfTheDay();
            return View(homeIndexViewModel);

            //return new ObjectResult(model);
        }
        public IActionResult Details(int id)
        {
            var rest = _resturant.Get(id);
            if (rest == null)
                return NotFound();
            else
                return View(rest);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ResturantEditModel resturantEdit)
        {
            Resturant newRresturant = new Resturant();
            newRresturant.Name = resturantEdit.Name;
            newRresturant.CusineType = resturantEdit.CusineType;

            var a = _resturant.Add(newRresturant);

            return View("Details", a);
        }
    }
}
