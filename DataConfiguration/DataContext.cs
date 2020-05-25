﻿using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food.DataConfiguration
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Resturant> Resturant { get; set; }

    }
}
