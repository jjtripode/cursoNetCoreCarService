using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string models { get; set; }

        [NotMapped]
        public string[] Models
        {
            get
            {
                return models.Split(',');
            }
        }
    }
}