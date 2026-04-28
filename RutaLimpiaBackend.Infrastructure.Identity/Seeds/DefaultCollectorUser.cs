using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace RutaLimpiaBackend.Infrastructure.Identity.Seeds
{
    public static class DefaultCollectorUser
    {
        public static async Task SeedAsync(UserManager<User> userManager)
        {
            var email = "mariamarte@gmail.com";
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                User user1 = new()
                {
                    Name = "María Marte",
                    SectorId = Guid.Empty,
                    Email = email,
                    EmailConfirmed = true,
                    PhoneNumber = "8499010910",
                    UserName = "MaríaMarte123",
                };
                User collector = user1;

                var result = await userManager.CreateAsync(collector, "123Pa$$word!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(collector, Roles.COLLECTOR.ToString());
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