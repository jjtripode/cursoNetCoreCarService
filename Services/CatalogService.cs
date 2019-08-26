using System;
using System.Linq;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Services
{
    public class CatalogService : ICatalogService
    {
         private readonly AppDbContext _context;

        public CatalogService(AppDbContext context)
        {
            _context = context;
        }
          public async Task<ServiceType[]> GetAllServicesTypeAsync()
        {
            return await _context.ServicesType.ToArrayAsync();
        }

        public async Task<ServiceStatus[]> GetAllServicesStatusAsync()
        {
            return await _context.ServiceStatus.ToArrayAsync();
        }

        public async Task<ServiceStatus> GetServicesStatusByIdAsync(Guid id)
        {
            return await _context.ServiceStatus.Where(v => v.ID == id).FirstOrDefaultAsync();
        }

        public async Task<ServiceType> GetServiceTypeByIdAsync(Guid id)
        {
            return await _context.ServicesType.Where(v => v.ID == id).FirstOrDefaultAsync();
        }

        public async Task<Price[]> GetAllPricesAsync()
        {
            return await _context.Prices.ToArrayAsync();
        }

        public async Task<Price> GetPriceById(Guid id)
        {
            return await _context.Prices.Where(p=> p.ID == id ).FirstOrDefaultAsync();
        }
    }
}