namespace Drivers.Api.Models.DTOs;

public class LoginRequestResponse : AuthResult
{
    public string RefreshToken { get; set; }
}
