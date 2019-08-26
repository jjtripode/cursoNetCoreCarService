using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class ServiceStatus
    {
        [Key]
        public Guid ID
        {
            get; set;
        }

        public int IdStatus { get; set; }
        public string Descripcion { get; set; }

    }
}