using System;

namespace CursoNetCoreCarService.Models
{
    public class CarService
    {
        public string Description { get; set; }
        public DateTime Date{get;set;}
        public decimal Cost { get; set; }
        public string Status{ get; set; }
    }
}