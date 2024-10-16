namespace TicketManagementUI.Extensions;

public static class DateTimeExtensions
{
    #region Public methods declaration

    public static string BeautifyDate(this DateTime date)
    {
        return date.ToString("dd MMMM yyyy hh:mm tt");
    }

    #endregion
}