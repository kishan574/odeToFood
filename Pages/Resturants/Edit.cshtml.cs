using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ode2Food.Models;
using ode2Food.Services;

namespace ode2Food.Pages.Resturants
{
    public class EditModel : PageModel
    {
        private IResturant _resturantData;
        
        [BindProperty]
        public Resturant resturant { get; set; }

        public EditModel(IResturant resturantData)
        {
            _resturantData = resturantData;
        }
        public IActionResult OnGet(int id)
        {
            resturant = _resturantData.Get(id);
            if (resturant == null)
                return Redirect("/home/index");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Resturants/Edit?id=2");
            }

            return Redirect("/home/index");
            //return Page();
        }
    }
}
