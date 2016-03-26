using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace optionPricing.Models
{
    public class stockContext : DbContext
    {
        public DbSet<option> options { get; set; }
        public DbSet<stock> stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer();

            base.OnConfiguring(optionsBuilder);
        }
       
    }


   
}
