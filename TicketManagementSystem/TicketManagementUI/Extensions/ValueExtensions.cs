namespace TicketManagementUI.Extensions;

public static class ValueExtensions
{
    #region Public methods declaration

    public static int? ToNullableInteger(this string value)
    {
        var isSuccess = int.TryParse(value, out var res);
        return isSuccess ? res : null;
    }

    #endregion
}