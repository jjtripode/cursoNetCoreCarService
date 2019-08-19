using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Services;

namespace CarServiceFronted.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleServices _vehicleServices;

        private readonly IBrandServices _brandServices;

        public VehiclesController(IVehicleServices vehicleService, IBrandServices brandServices)
        {
            _vehicleServices = vehicleService;
            _brandServices = brandServices;
        }
        public async Task<IActionResult> Index()
        {
            var addVehicleViewModel = new AddVehicleViewModel();

            addVehicleViewModel.Brands = await _brandServices.GetAllBrandsAsync();
            addVehicleViewModel.Models = addVehicleViewModel.Brands[0].Models;

            var vehicleViewModel = new VehicleViewModel()
            {
                Items = await _vehicleServices.GetAllVehiclesAsync(),
                AddVehicleViewModel = addVehicleViewModel
            };


            return View(vehicleViewModel);

        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetVehicle()
        {
            return View(new AddVehicleViewModel()
            {
                Brands = await _brandServices.GetAllBrandsAsync(),
                Models = new string[] { }
            }
            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVehicle(AddVehicleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var vehicle = new Vehicle()
            {
                Model = model.VehicleModel,
                Brand = model.Brand,
                ManufacturingDate = model.ManufacturingDate,
                CarLicensePlate = model.CarLicensePlate
            };

            var successful = await _vehicleServices.AddVehicleAsync(vehicle);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }
            
            return RedirectToAction("Index");
        }
    }
}
