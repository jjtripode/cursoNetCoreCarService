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
                .Where(x => x.Name == Roles.AdministratorRole)
                .SingleOrDefaultAsync().Result != null)
                return;

            var testAdmin = new IdentityRole
            {
                Name = Roles.AdministratorRole,
                NormalizedName = Roles.AdministratorRole.ToUpper()
            };

            IdentityResult result = roleManager.CreateAsync(testAdmin).Result;
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
                userManager.AddToRoleAsync(testAdmin, Roles.AdministratorRole).Wait();
            }
        }
    }
}
