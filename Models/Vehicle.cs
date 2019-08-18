using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CarServiceFronted.Models
{
    public class Vehicle
    {
       
        [Key]
        public Guid ID
        {
            get ;set;
        }

        public string CarLicensePlate { get; set; } 

        public DateTime ManufacturingDate { get; set; }

        public Brand Brand { get; set; }

        public Model Model { get; set; }

        public IList<Service> Services { get; set; }
    }
}