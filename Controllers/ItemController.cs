using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using r1whms.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace r1whms.Controllers
{
    public class ItemController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(String Id) {
            // TODO read from db
            Item i = new Item();
            return View(i);
        }

        public IActionResult New() {
            Item i = new Item();
            i.Name = "";
            i.Description = "";
            return View("Edit", i);
        }

        public IActionResult Delete(String Id) {
            return View();
        }
    }
}
