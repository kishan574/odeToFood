using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ode2Food.Services;
using ode2Food.Models;

namespace ode2Food.Pages.Resturants
{
    public class EditModel : PageModel
    {
        private SqlResturantData _resturantData;
        public Resturant resturant;

        public EditModel(SqlResturantData resturantData)
        {
            _resturantData = resturantData;
        }
        public IActionResult OnGet(int id)
        {
            resturant = _resturantData.Get(id);
            if (resturant == null)
                return RedirectToAction("Index", "Home");

                return Page();
        }
    }
}