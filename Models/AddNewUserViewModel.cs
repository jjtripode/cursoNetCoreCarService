using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarServiceFronted.Models
{
    public class AddNewUserViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public IList<string> Roles { get; set; }
        [Required]
        public string Rol { get; set; }
    }
}