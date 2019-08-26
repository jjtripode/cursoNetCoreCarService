using System;
using System.Threading.Tasks;
using CarServiceFronted.Models;

namespace CursoNetCoreCarService.Services
{
    public interface IBrandServices
    {
         Task<Brand[]> GetAllBrandsAsync();
          Task<Brand> GetBrandByIdAsync(Guid id);
    }
}