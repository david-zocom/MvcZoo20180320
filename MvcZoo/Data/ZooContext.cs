using Microsoft.EntityFrameworkCore;
using MvcZoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcZoo.Data
{
    public class ZooContext : DbContext
    {
        // connection string ligger gömd i options
        public ZooContext(DbContextOptions options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cage> Cages { get; set; }
    }
}
