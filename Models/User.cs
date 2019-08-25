using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace CarServiceFronted.Models
{
    public class User
    {
        public IdentityUser IdentityUser { get; set; }
        public IList<string> Roles { get; set; }

        public string RolesToString()
        {
            return string.Join(", ", Roles);//.Aggregate("",(current,next)=> $"{current}, {next}");
        }
    }
}