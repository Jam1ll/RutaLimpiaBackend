using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager)
        {
            {
                foreach (var roleName in new[] { Roles.SUPERADMIN.ToString(), Roles.ADMIN.ToString(), Roles.COLLECTOR.ToString(), Roles.CITIZEN.ToString() })
                {
                    if(!await roleManager.RoleExistsAsync(roleName))
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
            }
        }
    }
}