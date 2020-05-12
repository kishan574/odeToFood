using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ode2Food.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }
        public string Greeter { get; set; }
    }
}
