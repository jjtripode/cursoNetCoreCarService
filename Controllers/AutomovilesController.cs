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
            var item1 =new Automovil(){Marca="Peugeot", Modelo="207", FechaFabricacion=DateTime.Now.AddYears(-11)};

            var item2 =new Automovil(){Marca="Fiat", Modelo="Siena", FechaFabricacion=DateTime.Now.AddYears(-5)};
            

            var items = AutomovilesViewModel();
            items.Items = new []{item1, item2};
            
            return Index(items);

        }

      
    }
}
