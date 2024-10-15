namespace Domain.DTOs.Requests;

public class RegisterUserRequest
{
    public string? Email { get; set; }
    public string? Role { get; set; }
}