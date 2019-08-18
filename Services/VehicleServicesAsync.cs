using System;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using Microsoft.EntityFrameworkCore;


namespace CursoNetCoreCarService.Services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly AppDbContext _context;

        public VehicleServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Service[]> GetServicesAsync()
        {
            return await _context.Services.ToArrayAsync();
        }

        public async Task<bool> AddVehicleAsync(Vehicle vehicle)
        {
            vehicle.ID = Guid.NewGuid();

            _context.Vehicles.Add(vehicle);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<Vehicle[]> GetAllVehiclesAsync()
        {
            return await _context.Vehicles.ToArrayAsync();
        }
    }
}
