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
        [Required]
        public DateTime Date{get;set;}
        [Required]

        public decimal Price { get; set; }

        [Required]
        public Guid StatusId{ get; set; }
        public ServiceStatus[] StatusList{ get; set; }

        public ServiceType[] ServicesType{ get; set; }

        [Required]
        public Guid ServiceTypeId{ get; set; }
        [Required]
        public Guid VehicleId { get;  set; }


        public AddServiceViewModel GetAddServiceViewModel(Guid id)
        {
            this.VehicleId = id;  
            
            return this;
        }
    }
}