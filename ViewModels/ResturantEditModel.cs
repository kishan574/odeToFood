using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ode2Food.ViewModels
{
    public class ResturantEditModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public Cusine CusineType { get; set; }
    }
}
