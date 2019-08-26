using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using CursoNetCoreCarService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceFronted.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleServices _vehicleServices;
        private readonly IBrandServices _brandServices;
        private readonly ICatalogService _catalogService;
        private readonly UserManager<IdentityUser> _userManager;

        public VehiclesController(
            IVehicleServices vehicleService,
            IBrandServices brandServices,
            ICatalogService catalogService,
            UserManager<IdentityUser> userManager)
        {
            _vehicleServices = vehicleService;
            _brandServices = brandServices;
            _catalogService = catalogService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();

            var vehicleViewModel = new VehicleViewModel()
            {
                Items = await _vehicleServices.GetAllVehiclesAsync(),

                StatusList = await _catalogService.GetAllServicesStatusAsync(),
                ServicesType = await _catalogService.GetAllServicesTypeAsync(),
                AddVehicleViewModel = await this.GetAddVehicleViewModel()
            };

            return View(vehicleViewModel);
        }
        
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> DetailsService(Guid vehicleId)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();

            var vehicle = await _vehicleServices.GetVehicleByIdAsync(vehicleId);
            var detailServicesViewModel = new DetailServicesViewModel()
            {
                Services = vehicle.Services
            };

            return PartialView("DetailsServicePartial", detailServicesViewModel);
        }

        private async Task<AddVehicleViewModel> GetAddVehicleViewModel()
        {
            var addVehicleViewModel = new AddVehicleViewModel();

            addVehicleViewModel.Brands = await _brandServices.GetAllBrandsAsync();
            addVehicleViewModel.Models = addVehicleViewModel.Brands[0].Models;
            addVehicleViewModel.ManufacturingDate = DateTime.Today;

            return addVehicleViewModel;
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetVehicle()
        {
            return View(new AddVehicleViewModel()
            {
                Brands = await _brandServices.GetAllBrandsAsync(),
                Models = new string[] { }
            });
        }

        [Authorize]
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


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreateService(Guid vehicleId)
        {

            var addServiceViewModel = new AddServiceViewModel()
            {
                StatusList = await _catalogService.GetAllServicesStatusAsync(),
                ServicesType = await _catalogService.GetAllServicesTypeAsync(),
                Prices = await _catalogService.GetAllPricesAsync(),
                VehicleId = vehicleId
            };

            return PartialView("AddServicePartial", addServiceViewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddService(AddServiceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var vehicle = await _vehicleServices.GetVehicleByIdAsync(model.VehicleId);
            var ServiceType = await _catalogService.GetServiceTypeByIdAsync(model.ServiceTypeId);
            var ServicesStatus = await _catalogService.GetServicesStatusByIdAsync(model.StatusId);
            var price = await _catalogService.GetPriceById(model.PriceId);


            var service = new Service()
            {
                Price = price,
                Date = model.Date,
                Status = ServicesStatus,
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