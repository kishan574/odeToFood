using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ode2Food.Services
{
    public interface IResturant
    {
        public IEnumerable<Resturant> GetAll();
        public Resturant Get(int id);
        public Resturant Add(Resturant resturant);
    }
}
