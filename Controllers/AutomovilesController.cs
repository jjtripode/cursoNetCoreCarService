using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarServiceFronted.Models;

namespace CarServiceFronted.Controllers
{
    public class AutomovilesController : Controller
    {
        public IActionResult Index()
        {
            var item1 =new Car(){Brand="Peugeot", Model="207", Date=DateTime.Now.AddYears(-11)};

            var item2 =new Car(){Brand="Fiat", Model="Siena", Date=DateTime.Now.AddYears(-5)};
            

            var items = new CarViewModel();
            items.Items = new []{item1, item2};
            
            return View(items);
        }
    }
}
