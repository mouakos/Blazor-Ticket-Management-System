namespace Infrastructure.Common;

public static class Constants
{
    #region Public constants declaration

    public const string c_DefaultAvatar = "avatar.png";

    public const string c_DefaultPassword = "NeedToReset%3";
    public const string c_RoleAdmin = "Admin";

    public const string c_RoleAdminId = "48395b9b-a292-4a48-80df-ebc6a057f6c0";
    public const string c_RoleUser = "User";
    public const string c_RoleUserId = "6367a40d-3014-43bc-a704-135f41abae2d";
    public const string c_StatusClosed = "CLOSED";
    public const string c_StatusNew = "NEW";
    public const string c_StatusOpen = "OPEN";

    #endregion

    #region Public fields declaration

    public static readonly Dictionary<string, string> UserRoles = new()
    {
        { c_RoleAdminId, c_RoleAdmin },
        { c_RoleUserId, c_RoleUser }
    };

    #endregion
}