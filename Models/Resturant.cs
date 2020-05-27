using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ode2Food.Models
{
    public class Resturant
    {
        public int Id { get; set; }
        [Display(Name = "Resturant Name")]
        public string Name { get; set; }

        [Display(Name = "Cusine")]
        public Cusine CusineType { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
