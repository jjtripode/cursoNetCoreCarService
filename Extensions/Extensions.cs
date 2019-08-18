using System;
using System.Collections.Generic;
using System.Linq;
using CarServiceFronted.Models;

namespace CarServiceFronted.Extensions {
    public static class Extensions {
       public static string GetNextCarServices (this Vehicle car) {

            if (car.Services != null && car.Services.Any() &&
                car.Services.Any (s => s.Status == "Pending")) {
                return car.Services.Where (s => s.Status == "Pending").First ().Date.ToString ();
            }
            return "Sin services pendientes";
        }
    }
}