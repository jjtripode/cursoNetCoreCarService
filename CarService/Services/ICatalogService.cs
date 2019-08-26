using System;
using System.Threading.Tasks;
using CarServiceFronted.Models;

namespace CursoNetCoreCarService.Services
{
    public interface ICatalogService
    {
          Task<Price[]> GetAllPricesAsync();
          Task<ServiceType[]> GetAllServicesTypeAsync();
          Task<ServiceStatus[]> GetAllServicesStatusAsync();
          Task<ServiceStatus> GetServicesStatusByIdAsync(Guid id);
          Task<ServiceType> GetServiceTypeByIdAsync(Guid id);
          Task<Price> GetPriceById(Guid id);
    }
}