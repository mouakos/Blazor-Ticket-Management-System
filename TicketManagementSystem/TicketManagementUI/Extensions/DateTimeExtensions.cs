namespace TicketManagementUI.Extensions;

public static class DateTimeExtensions
{
    public static string BeautifyDate(this DateTime date)
    {
        return date.ToString("dd MMMM yyyy hh:mm tt");
    }
}