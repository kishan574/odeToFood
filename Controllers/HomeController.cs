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
        [ValidateAntiForgeryToken]
        public IActionResult Create(ResturantEditModel resturantEdit)
        {
            if (ModelState.IsValid)
            {
                Resturant newRresturant = new Resturant();
                newRresturant.Name = resturantEdit.Name;
                newRresturant.CusineType = resturantEdit.CusineType;

                var a = _resturant.Add(newRresturant);

                //return View("Details", a); 
               
                ////when user decides to refresh the returned view,
                //the req. rendered will execute a http post req again to the application 
                //causing redundant data to be saved again.

                //inorder to solve the above mentioned 
                //issue we'll return a redirect action insted of a view.
                return RedirectToAction(nameof(Details), new { a.Id, status = "success" });
            }
            else
            {
                return View();
            }
        }
    }
}
