using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceFronted.Controllers {
    public class VehiclesController : Controller {
        private readonly IVehicleServices _vehicleServices;

        private readonly IBrandServices _brandServices;

        public VehiclesController (IVehicleServices vehicleService, IBrandServices brandServices) {
            _vehicleServices = vehicleService;
            _brandServices = brandServices;
        }
        public async Task<IActionResult> Index () {

            var vehicleViewModel = new VehicleViewModel () {
                Items = await _vehicleServices.GetAllVehiclesAsync (),

                StatusList = await _vehicleServices.GetAllServicesStatusAsync (),
                ServicesType = await _vehicleServices.GetAllServicesTypeAsync (),
                AddVehicleViewModel = await this.GetAddVehicleViewModel ()
            };

            return View (vehicleViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsService(Guid vehicleId) {

            var vehicle =  await _vehicleServices.GetVehicleByIdAsync(vehicleId);
            var detailServicesViewModel = new DetailServicesViewModel () {
               Services = vehicle.Services 
            };

            return PartialView ("DetailsServicePartial", detailServicesViewModel);

            
        }

        private async Task<AddVehicleViewModel> GetAddVehicleViewModel () {
            var addVehicleViewModel = new AddVehicleViewModel ();

            addVehicleViewModel.Brands = await _brandServices.GetAllBrandsAsync ();
            addVehicleViewModel.Models = addVehicleViewModel.Brands[0].Models;
            addVehicleViewModel.ManufacturingDate = DateTime.Today;

            return addVehicleViewModel;
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetVehicle () {
            return View (new AddVehicleViewModel () {
                Brands = await _brandServices.GetAllBrandsAsync (),
                    Models = new string[] { }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVehicle (AddVehicleViewModel model) {
           
            if (!ModelState.IsValid) {
                return RedirectToAction ("Index");
            }

            var vehicle = new Vehicle () {
                Model = model.VehicleModel,
                Brand = model.Brand,
                ManufacturingDate = model.ManufacturingDate,
                CarLicensePlate = model.CarLicensePlate
            };

            var successful = await _vehicleServices.AddVehicleAsync (vehicle);
            if (!successful) {
                return BadRequest ("Could not add item.");
            }

            return RedirectToAction ("Index");
        }


        [HttpGet]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateService (Guid vehicleId) {
           
           var addServiceViewModel = new AddServiceViewModel(){   
             StatusList = await _vehicleServices.GetAllServicesStatusAsync (),
              ServicesType = await _vehicleServices.GetAllServicesTypeAsync (),
              Prices = await _vehicleServices.GetAllPricesAsync(),
              VehicleId = vehicleId
           };

            return PartialView ("AddServicePartial", addServiceViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddService(AddServiceViewModel model) {
            if (!ModelState.IsValid) {
                return RedirectToAction ("Index");
            }

            var vehicle = await _vehicleServices.GetVehicleByIdAsync (model.VehicleId);
            var ServiceType = await _vehicleServices.GetServiceTypeByIdAsync (model.ServiceTypeId);
            var ServicesStatus = await _vehicleServices.GetServicesStatusByIdAsync (model.StatusId);
            var price = await _vehicleServices.GetPriceById(model.PriceId);


            var service = new Service () {
                Price = price,
                Date = model.Date,
                Status = ServicesStatus,
                ServiceType = ServiceType
            };

            var successful = await _vehicleServices.SaveOrUpdateAsync (service);

            if (vehicle.Services == null) {
                vehicle.Services = new List<Service> ();
            }

            vehicle.Services.Add (service);

            successful = await _vehicleServices.SaveOrUpdateAsync (vehicle);

            if (!successful) {
                return BadRequest ("Could not add item.");
            }

            return RedirectToAction ("Index");
        }
    }
}