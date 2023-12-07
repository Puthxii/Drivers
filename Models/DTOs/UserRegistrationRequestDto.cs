using System.ComponentModel.DataAnnotations;

namespace Drivers.Api.Models.DTOs;

public class UserRegistrationRequestDto
{
    [Required]
    public string Name { set; get; } = string.Empty;
    [Required]
    public string Email { set; get; } = string.Empty;
    [Required]
    public string Password { set; get; } = string.Empty;
}
