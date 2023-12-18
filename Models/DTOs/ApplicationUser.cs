using Microsoft.AspNetCore.Identity;

namespace Drivers.Api.Models.DTOs;

public class ApplicationUser: IdentityUser
{
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
}
