using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Services;

namespace CarServiceFronted.Controllers
{
    public class VehiclesController : Controller
    {
        IVehicleServices _service;
        public VehiclesController(IVehicleServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            // var item1 =new Car(){Brand="Peugeot", Model="207", Date=DateTime.Now.AddYears(-11), 
            // Services = Enumerable.Range(1,3).Select( e=> new CarService(){Description="service",Date=DateTime.Now,Cost=123,Status="Pending"}).ToList() };

            // var item2 =new Car(){Brand="Fiat", Model="Siena", Date=DateTime.Now.AddYears(-5),
            // Services = Enumerable.Range(1,3).Select( e=> new CarService(){Description="service",Date=DateTime.Now,Cost=123,Status="Pending"}).ToList() };


            // var items = new CarViewModel();
            // items.Items = new []{item1, item2};
            var items = await _service.GetAllVehiclesAsync();

            return View(new VehicleViewModel() { Items = items });

        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVehicle(Vehicle car)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _service.AddVehicleAsync(car);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }
            return RedirectToAction("Index");
        }
    }
}
