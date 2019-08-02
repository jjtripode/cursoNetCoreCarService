using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Models;

namespace CursoNetCoreCarService.Services
{
    public interface ICarServices
    {
         Task<Car[]> GetCarsAsync();

          Task<CarService[]> GetServicesAsync();
          Task<bool> AddCarAsync(Car car);
    }
}