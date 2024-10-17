using Microsoft.AspNetCore.Components.Forms;

namespace Domain.DTOs.Requests;

public class DiscussionRequest
{
    #region Public properties declaration

    public IList<IBrowserFile>? Attachments { get; set; }
    public string? Message { get; set; }
    public int TicketId { get; set; }

    #endregion
}