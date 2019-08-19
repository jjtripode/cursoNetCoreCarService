using System;

namespace CarServiceFronted.Models
{
    public class AddVehicleViewModel
    {
        public Brand[] Brands { get; set; }
        public string Brand { get; set; }

        public string[]  Models { get; set; }   
        public string VehicleModel { get; set; }   

        public string CarLicensePlate { get; set; } 

        public DateTime ManufacturingDate { get; set; }
    }
}