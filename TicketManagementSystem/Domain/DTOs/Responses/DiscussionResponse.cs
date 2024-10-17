using Domain.Entities;

namespace Domain.DTOs.Responses;

public class DiscussionResponse
{
    #region Public properties declaration

    public List<AttachmentResponse>? Attachments { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Message { get; set; }
    public User? User { get; set; }

    #endregion
}