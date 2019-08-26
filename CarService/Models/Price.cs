using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class Price
    {
        [Key]
        public Guid ID
        {
            get; set;
        }

        public Decimal Value { get; set; }
    }
}