using ode2Food.DataConfiguration;
using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ode2Food.Services
{
    public class SqlResturantData : IResturant
    {
        private DataContext _context;

        public SqlResturantData(DataContext context)
        {
            _context = context;
        }

        public Resturant Add(Resturant resturant)
        {
            _context.Resturant.Add(resturant);
            _context.SaveChanges();
            return resturant;
        }

        public Resturant Get(int id)
        {
            return _context.Resturant.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _context.Resturant.OrderBy(x => x.Name);
        }
    }
}
