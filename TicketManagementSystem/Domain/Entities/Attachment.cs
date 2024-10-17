using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Attachment
{
    #region Public properties declaration

    public DateTime CreatedDate { get; set; }
    public Discussion? Discussion { get; set; }
    [ForeignKey(nameof(Discussion))] public int? DiscussionId { get; set; }
    public string? FileName { get; set; }
    public long FileSize { get; set; }
    public int Id { get; set; }
    public string? ServerFileName { get; set; }
    public Ticket? Ticket { get; set; }
    [ForeignKey(nameof(Ticket))] public int? TicketId { get; set; }

    #endregion
}