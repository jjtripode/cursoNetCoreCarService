using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceFronted.Models
{
    public class Model
    {
        [Key]
        public Guid ID
        {
            get; set;
        }

        public string Descripcion { get; set; }

    }
}