using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Discussion
{
    #region Public properties declaration

    public virtual ICollection<Attachment>? Attachments { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? Id { get; set; }
    public string? Message { get; set; }
    public Ticket? Ticket { get; set; }
    [ForeignKey(nameof(Ticket))] public int TicketId { get; set; }
    [ForeignKey(nameof(UserId))] public User? User { get; set; }
    public string? UserId { get; set; }

    #endregion
}