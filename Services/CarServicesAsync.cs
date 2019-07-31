using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using CursoNetCoreCarService.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Services
{
    public class CarServicesAsync

        : ICarServices
    {
        private readonly AppDbContext _context;

        public CarServicesAsync(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Car[]> GetCarsAsync()
        {
            return await _context.Cars.ToArrayAsync();
        }

        public async Task<CarService[]> GetServicesAsync()
        {
            return await _context.Services.ToArrayAsync();
        }
    }
}
