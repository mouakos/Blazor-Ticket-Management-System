using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Domain.DTOs.Requests;

public class CreateTicketRequest
{
    #region Public fields declaration

    public IList<IBrowserFile>? Files;

    #endregion

    #region Public properties declaration

    [Required] public string? AssignedToId { get; set; }
    [Required] public int? CategoryId { get; set; }
    public string? Description { get; set; }
    [Required] public int? PriorityId { get; set; }
    [Required] public int? ProductId { get; set; }
    [Required] public string? Summary { get; set; }

    #endregion
}