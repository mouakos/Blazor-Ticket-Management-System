namespace TicketManagementUI.DTOs;

public class LoginDto
{
    #region Public properties declaration

    public string? Password { get; set; }
    public bool RememberMe { get; set; }
    public string? UserName { get; set; }

    #endregion
}