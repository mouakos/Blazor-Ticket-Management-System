using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Ticket
{
    #region Public properties declaration

    [ForeignKey(nameof(AssignedToId))] public User? AssignedTo { get; set; }

    public string? AssignedToId { get; set; }

    public virtual ICollection<Attachment>? Attachments { get; set; }
    [ForeignKey(nameof(CategoryId))] public Category? Category { get; set; }

    public int CategoryId { get; set; }

    public string? ClosedBy { get; set; }
    public DateTime? ClosedDate { get; set; }
    public string? Description { get; set; }
    public DateTime ExpectedDate { get; set; }
    public int Id { get; set; }
    public DateTime? LastUpdateDate { get; set; }
    [ForeignKey(nameof(PriorityId))] public Priority? Priority { get; set; }

    public int PriorityId { get; set; }
    [ForeignKey(nameof(ProductId))] public Product? Product { get; set; }

    public int ProductId { get; set; }

    public string? RaisedBy { get; set; }
    public DateTime RaisedDate { get; set; }

    public string? Status { get; set; }
    public string? Summary { get; set; }
    [ForeignKey(nameof(RaisedBy))] public User? User { get; set; }

    #endregion
}