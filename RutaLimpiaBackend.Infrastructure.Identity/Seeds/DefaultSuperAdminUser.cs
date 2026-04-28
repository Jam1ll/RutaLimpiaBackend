using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace RutaLimpiaBackend.Infrastructure.Identity.Seeds
{
    public static class DefaultSuperAdminUser
    {
        public static async Task SeedAsync(UserManager<User> userManager)
        {
            var email = "johnmarx@gmail.com";
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                User user1 = new()
                {
                    Name = "John Marx",
                    SectorId = Guid.Empty,
                    Email = email,
                    EmailConfirmed = true,
                    PhoneNumber = "8099080980",
                    UserName = "JohnMarx123",
                };
                User superAdmin = user1;

                var result = await userManager.CreateAsync(superAdmin, "123Pa$$word!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(superAdmin, Roles.ADMIN.ToString());
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"\n[ERROR DE IDENTITY]: {error.Code} - {error.Description}\n");
                    }
                }
            }
        }
    }
}