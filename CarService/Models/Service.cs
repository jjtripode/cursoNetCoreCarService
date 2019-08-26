using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class Service
    {
         [Key]
        public Guid ID
        {
            get ;set;
        }
        public string Description { get; set; }
        public DateTimeOffset Date{get;set;}
        public Price Price { get; set; }
        public ServiceStatus Status{ get; set; }
        public ServiceType ServiceType{ get; set; }
    }
}