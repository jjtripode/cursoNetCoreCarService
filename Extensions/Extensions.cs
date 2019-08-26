using System.Linq;
using CarServiceFronted.Models;
using Humanizer;
using System;

namespace CarServiceFronted.Extensions {
    public static class Extensions {
       public static string GetNextCarServices (this Vehicle car) {

            if (car.Services != null && car.Services.Any() &&
                car.Services.Any (s => s.Status.IdStatus  != 40 )) {
                return car.Services.Where (s => s.Status.IdStatus  != 40 ).OrderBy(s=> s.Date).First().Date.Humanize();
            }
            return "Sin services pendientes";
        }

        public static string Antiguedad (this DateTime date)
        {
                if (DateTime.Now.Year -date.Year==0)
                {
                    return "Menos de un año";
                }

                return  DateTime.Now.Year -date.Year + " años";
        }
    }
}