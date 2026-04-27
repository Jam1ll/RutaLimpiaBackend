using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace RutaLimpiaBackend.Infrastructure.Identity.Seeds
{
    public static class DefaultCitizenUser
    {
        public static async Task SeedAsync(UserManager<User> userManager)
        {
            var email = "pedrobonilla@gmail.com";
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                User user1 = new()
                {
                    Name = "Pedro Bonilla",
                    IdSector = "b16c35bf-a6d8-46df-8574-167a79336b86",
                    Email = email,
                    EmailConfirmed = true,
                    PhoneNumber = "8296083980",
                    UserName = "PedroBonilla123",
                };
                User citizen = user1;

                var result = await userManager.CreateAsync(citizen, "123Pa$$word!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(citizen, Roles.CITIZEN.ToString());
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