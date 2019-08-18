using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class Brand
    {
        [Key]
        public Guid ID
        {
            get; set;
        }

        public string Descripcion { get; set; }

        public Model Models { get; set; }
    }
}