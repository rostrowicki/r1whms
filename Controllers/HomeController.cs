using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using r1whms.Models;

namespace r1whms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Warehouse A";

            var itemList = new List<Item> {
                new Item() {Id = 0, Name="Item0", Description="Item0 Description"},
                new Item() {Id = 1, Name="Item1", Description="Item1 Description"},
                new Item() {Id = 2, Name="Item2", Description="Item2 Description"}
            };
            
            return View(itemList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
