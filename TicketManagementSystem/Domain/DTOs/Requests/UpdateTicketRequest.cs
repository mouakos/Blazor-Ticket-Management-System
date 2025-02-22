﻿using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class UpdateTicketRequest
{
    #region Public properties declaration

    [Required] public string? AssignedToId { get; set; }
    [Required] public int? CategoryId { get; set; }
    [Required] public int? PriorityId { get; set; }
    [Required] public int? ProductId { get; set; }
    public string? Status { get; set; }
    [Required] public int TicketId { get; set; }

    #endregion
}