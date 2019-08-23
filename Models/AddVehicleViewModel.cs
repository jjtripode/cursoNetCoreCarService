using System;
using System.ComponentModel.DataAnnotations;
namespace CarServiceFronted.Models
{
    public class AddVehicleViewModel
    {
        public Brand[] Brands { get; set; }
        
        [Required]
        public string Brand { get; set; }

        public string[]  Models { get; set; }   
        public string VehicleModel { get; set; }   
        [Required]
        [StringLength(8, ErrorMessage = "{0} la Patente debe estar entre {2} and {1}.", MinimumLength = 6)]
        public string CarLicensePlate { get; set; } 
        [Required]
        public DateTime ManufacturingDate { get; set; }
        public DateTimeOffset ManufacturingDate1 { get; set; }
    }
}