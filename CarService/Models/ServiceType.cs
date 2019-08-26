using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceFronted.Models
{
    public class ServiceType
    {
        [Key]
        public Guid ID
        {
            get; set;
        }

        public string Descripcion { get; set; }
    }
}