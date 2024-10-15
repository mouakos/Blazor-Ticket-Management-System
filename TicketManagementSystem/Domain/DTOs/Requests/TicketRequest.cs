namespace Domain.DTOs.Requests;

public class TicketRequest
{
    public string? Summary { get; set; }
    public int[]? ProductId { get; set; }
    public int[]? CategoryId { get; set; }
    public int[]? PriorityId { get; set; }
    public string[]? Status { get; set; }
    public string[]? RaisedBy { get; set; }
}