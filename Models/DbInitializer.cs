using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace r1whms.Models
{
    public class DbInitializer
    {

        public static void Initialize(AppDbContext context) {
            context.Database.EnsureCreated();

            if (context.Items.Any())
            {
                return; // DB has been seeded
            }

            var items = new Item[] {
                new Item{Id = 0, Name = "CPU", Description="i5"},
                new Item{Id = 1, Name = "GPU", Description="RX480"},
                new Item{Id = 2, Name = "Mouse", Description="g600"},
                new Item{Id = 3, Name = "Keyboard", Description="AlloyFPS"}
            };

            foreach (Item i in items)
            {
                
            }

            var warehouses = new Warehouse[] {
                new Warehouse{Id=0, Name="Basement", Description="Basement Storage Box"},
                new Warehouse{Id=1, Name="Garage", Description="Garage Container"}
            };

            foreach (Warehouse w in warehouses)
            {
                context.Warehouses.Add(w);
            }

            context.SaveChanges();
            
        }

        public DbInitializer()
        {
        }
    }
}
