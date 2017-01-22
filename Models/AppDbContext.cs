using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace r1whms.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Filename=./r1whms.db");
        }        
        public AppDbContext()
        {
        }
    }
}
