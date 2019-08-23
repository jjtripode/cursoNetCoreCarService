using System;
using System.Threading.Tasks;
using CarServiceFronted.Models;

namespace CursoNetCoreCarService.Services
{
    public interface IVehicleServices
    {
         Task<Vehicle[]> GetAllVehiclesAsync();
          Task<Service[]> GetServicesAsync();
          Task<bool> AddVehicleAsync(Vehicle car);
          Task<Vehicle> GetVehicleByIdAsync(Guid vehicleId);
          Task<Price[]> GetAllPricesAsync();
          Task<ServiceType[]> GetAllServicesTypeAsync();
          Task<ServiceStatus[]> GetAllServicesStatusAsync();
          Task<ServiceStatus> GetServicesStatusByIdAsync(Guid id);
          Task<ServiceType> GetServiceTypeByIdAsync(Guid id);

          Task<bool> SaveOrUpdateAsync(Vehicle vehicle);
          Task<bool> SaveOrUpdateAsync(Service service);
          Task<Price> GetPriceById(Guid id);
    }
}