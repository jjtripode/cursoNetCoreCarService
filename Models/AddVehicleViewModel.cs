using System;
using System.Collections.Generic;

namespace CarServiceFronted.Models
{
    public class AddVehicleViewModel
    {
        public IList<Brand> Brands { get; set; }
        public Guid BrandId { get; set; }

        public IList<Model>  Models { get; set; }   
        public Guid ModelId { get; set; }   

        public string CarLicensePlate { get; set; } 

        public DateTime ManufacturingDate { get; set; }
    }
}