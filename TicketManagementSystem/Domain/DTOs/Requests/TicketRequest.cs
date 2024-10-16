namespace Domain.DTOs.Requests;

public class TicketRequest
{
    #region Public properties declaration

    public int[]? CategoryId { get; set; }
    public int[]? PriorityId { get; set; }
    public int[]? ProductId { get; set; }
    public string[]? RaisedBy { get; set; }
    public string[]? Status { get; set; }
    public string? Summary { get; set; }

    #endregion
}