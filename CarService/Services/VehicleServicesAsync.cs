using System;
using System.Linq;
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

        public async Task<bool> SaveOrUpdateAsync(Vehicle vehicle)
        {
            var updatedVehicle = await _context.Vehicles.Where(v => v.ID == vehicle.ID).FirstOrDefaultAsync();
            updatedVehicle.Services = vehicle.Services;
            _context.Vehicles.Update(vehicle);
           
            var result =  await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Vehicle[]> GetAllVehiclesAsync()
        {
            return await _context.Vehicles.Include(v=> v.Services)
               .Include(v=> v.Services).ThenInclude(s => s.ServiceType)
            .Include(v=>v.Services).ThenInclude( s=>s.Status)
            .Include(v=>v.Services).ThenInclude( s=>s.Price)
            .ToArrayAsync();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(Guid vehicleId)
        {
            return await _context.Vehicles.Where(v => v.ID == vehicleId)
            .Include(v=> v.Services).ThenInclude(s => s.ServiceType)
            .Include(v=>v.Services).ThenInclude( s=>s.Status)
            .Include(v=>v.Services).ThenInclude( s=>s.Price)
            .FirstOrDefaultAsync();
        }

        public async Task<bool> SaveOrUpdateAsync(Service service)
        {
            if (service.ID == Guid.Empty)
            {
                service.ID = Guid.NewGuid();
                _context.Services.Add(service);
            }
            else
            {
                _context.Services.Update(service);
            }

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
