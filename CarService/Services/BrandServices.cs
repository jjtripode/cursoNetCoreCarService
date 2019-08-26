using System;
using System.Linq;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Services
{
    public class BrandServices : IBrandServices
    {
        private readonly AppDbContext _context;

        public BrandServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Brand[]> GetAllBrandsAsync()
        {
            return await _context.Brands.ToArrayAsync();
        }

        public async Task<Brand> GetBrandByIdAsync( Guid id)
        {   
            return await _context.Brands.Where( b=> b.ID == id).FirstOrDefaultAsync();
        }
    }
}