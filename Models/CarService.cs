using System;
using System.ComponentModel.DataAnnotations;

namespace CursoNetCoreCarService.Models
{
    public class CarService
    {
         [Key]
        public Guid ID
        {
            get ;set;
        }
        public string Description { get; set; }
        public DateTime Date{get;set;}
        public decimal Cost { get; set; }
        public string Status{ get; set; }
    }
}