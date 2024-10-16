namespace Domain.DTOs.Requests;

public class RegisterUserRequest
{
    #region Public properties declaration

    public string? Email { get; set; }
    public string? Role { get; set; }

    #endregion
}