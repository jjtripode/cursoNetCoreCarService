using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarServiceFronted.Models
{
    public class EditUserViewModel
    {
        public IList<string> Roles { get; set; }
        [Required]
        public string Rol { get; set; }
        public IdentityUser User { get;  set; }
        public string UserId { get;  set; }
    }
}