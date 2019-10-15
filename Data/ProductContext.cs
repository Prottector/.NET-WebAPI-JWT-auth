using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeMugApplicationProject.Models;

namespace CoffeMugApplicationProject.Data
{
    public class ProductContext  : DbContext
    {
        

        public ProductContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
        
    }
}
