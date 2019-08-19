using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Services;
using System;
using System.Collections.Generic;

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
                AddVehicleViewModel = addVehicleViewModel,
                ServicesType = await _vehicleServices.GetAllServicesTypeAsync(),
                StatusList = await _vehicleServices.GetAllServicesStatusAsync()
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddService(AddServiceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var vehicle = await _vehicleServices.GetVehicleByIdAsync(model.VehicleId);
            var ServiceType = await _vehicleServices.GetServiceTypeByIdAsync(model.ServiceTypeId);
            var ServicesStatus = await _vehicleServices.GetServicesStatusByIdAsync(model.StatusId);

            var service = new Service()
            {
                Price = model.Price,
                Date = model.Date,
                Status = ServicesStatus.Descripcion,
                ServiceType = ServiceType
            };

           var successful = await _vehicleServices.SaveOrUpdateAsync(service);

            if (vehicle.Services == null)
            {
                vehicle.Services = new List<Service>();
            }
            
            vehicle.Services.Add(service);

            successful = await _vehicleServices.SaveOrUpdateAsync(vehicle);
            
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }

            return RedirectToAction("Index");
        }
    }
}
