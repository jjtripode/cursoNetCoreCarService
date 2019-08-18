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
        public string Description { get; set; }
        public DateTime Date{get;set;}
        public decimal Price { get; set; }
        public string Status{ get; set; }
    }
}