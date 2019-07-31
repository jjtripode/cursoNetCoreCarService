using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CursoNetCoreCarService.Models;

namespace CarServiceFronted.Models
{
    public class Car
    {
       
        [Key]
        public Guid ID
        {
            get ;set;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime Date { get; set; }

        public IList<CarService> Services { get; set; }

    }
}