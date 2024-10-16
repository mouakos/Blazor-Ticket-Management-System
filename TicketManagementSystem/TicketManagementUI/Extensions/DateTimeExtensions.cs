namespace TicketManagementUI.Extensions;

public static class DateTimeExtensions
{
    public static string BeautifyDate(this DateTime date)
    {
        return date.ToString("dd MMM yyyy hh:mm tt");
    }
}