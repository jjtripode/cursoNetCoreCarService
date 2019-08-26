using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class AddServiceViewModel
    {
         [Key]
        public Guid ID
        {
            get ;set;
        }
        
        public DateTime Date{get;set;}
        

        public decimal Price { get; set; }

        
        public Guid StatusId{ get; set; }
        public Price[] Prices{ get; set; }
        public ServiceStatus[] StatusList{ get; set; }
        public ServiceType[] ServicesType{ get; set; }

        public Guid ServiceTypeId{ get; set; }
       
        public Guid VehicleId { get;  set; }
        public Guid PriceId { get;  set; }
    }
}