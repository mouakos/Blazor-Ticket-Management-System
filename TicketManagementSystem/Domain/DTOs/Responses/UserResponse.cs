namespace Domain.DTOs.Responses;

public class UserResponse
{
    #region Public properties declaration

    public bool AccountConfirmed { get; set; }

    public string? Avatar { get; set; }
    public string? Email { get; set; }
    public string? Id { get; set; }
    public string? Role { get; set; }

    #endregion
}