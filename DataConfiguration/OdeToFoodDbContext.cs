using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food.DataConfiguration
{
    public class OdeToFoodDbContext : DbContext
    {
        //Design pattern must be strictly followed!! 
        //as {fileName}DbContext.
        //else Following exception occurs as the entity framework core 
        //follows the strictly followed design pattern.
        //Exception --> 
        //Unable to create an object of type 'DataContext'. 
        //For the different patterns supported at design time, 
        //see https://go.microsoft.com/fwlink/?linkid=851728
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Resturant> Resturant { get; set; }

    }
}
