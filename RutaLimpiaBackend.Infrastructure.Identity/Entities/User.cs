using Microsoft.AspNetCore.Identity;

namespace RutaLimpiaBackend.Infrastructure.Identity.Entities
{
    public class User : IdentityUser
    {
        public required string Name { get; set; }
        public Guid SectorId { get; set; }

        //email in IdentityUser
        //phoneNumber in IdentityUser
        //passwordHash in IdentityUser

        public string? PhotoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
