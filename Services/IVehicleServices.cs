using System.Threading.Tasks;
using CarServiceFronted.Models;

namespace CursoNetCoreCarService.Services
{
    public interface IVehicleServices
    {
         Task<Vehicle[]> GetAllVehiclesAsync();
          Task<Service[]> GetServicesAsync();
          Task<bool> AddVehicleAsync(Vehicle car);
    }
}