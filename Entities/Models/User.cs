using Microsoft.AspNetCore.Identity;
using System;

namespace Entities.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; } = DateTime.UtcNow.AddDays(1); // Por ejemplo, expira en 1 día

    }
}
