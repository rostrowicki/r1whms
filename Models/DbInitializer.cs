using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace r1whms.Models
{
    public class DbInitializer
    {

        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            var items = new Item[] { };

            if (!context.Items.Any())
            {
                items = new Item[] {
                new Item{Name = "CPU", Description="i5"},
                new Item{Name = "GPU", Description="RX480"},
                new Item{Name = "Mouse", Description="g600"},
                new Item{Name = "Keyboard", Description="AlloyFPS"}
            };
            }

            foreach (Item i in items)
            {
                context.Items.Add(i);
            }

            context.SaveChanges();

            var warehouses = new Warehouse[] { };

            if (!context.Warehouses.Any())
            {

                warehouses = new Warehouse[] {
                new Warehouse{Name="Basement", Description="Basement Storage Box"},
                new Warehouse{Name="Garage", Description="Garage Container"}
            };

            }

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
