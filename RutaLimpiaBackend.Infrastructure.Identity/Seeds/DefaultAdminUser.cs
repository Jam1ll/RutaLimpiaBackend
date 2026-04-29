using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace RutaLimpiaBackend.Infrastructure.Identity.Seeds
{
    public static class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<User> userManager)
        {
            var email = "juanperez@gmail.com";
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                User user1 = new()
                {
                    Name = "Juan Perez",
                    SectorId = Guid.Empty,
                    Email = email,
                    EmailConfirmed = true,
                    PhoneNumber = "8099080980",
                    UserName = "JuanPerez123",
                };
                User admin = user1;

                var result = await userManager.CreateAsync(admin, "123Pa$$word!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, Roles.ADMIN.ToString());
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