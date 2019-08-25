using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Entities
{
    public static class RolesAndUsersInitializer
    {
        public static void SeedRole(RoleManager<IdentityRole> roleManager)
        {
            if (roleManager.Roles
                .Where(x => x.Name == Roles.Administrator)
                .SingleOrDefaultAsync().Result == null)

            {
                var adminRol = new IdentityRole
                {
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                };

                roleManager.CreateAsync(adminRol);
            }

            if (roleManager.Roles
              .Where(x => x.Name == Roles.Vendedor)
              .SingleOrDefaultAsync().Result == null)
            {
                var VendedorRol = new IdentityRole
                {
                    Name = Roles.Vendedor,
                    NormalizedName = Roles.Vendedor.ToUpper()
                };

                roleManager.CreateAsync(VendedorRol);
            }
        }

        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.Users
                .Where(x => x.UserName == "admin@todo.local")
                .SingleOrDefaultAsync().Result != null)
                return;

            var testAdmin = new IdentityUser
            {
                UserName = "admin@todo.local",
                Email = "admin@todo.local"
            };

            IdentityResult result = userManager.CreateAsync(testAdmin, "NotSecure123!!").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(testAdmin, Roles.Administrator).Wait();
            }
        }
    }
}
