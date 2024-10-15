using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;

namespace Infrastructure.Services;

public class TicketService(IUnitOfWork unitOfWork) : ITicketService
{
    /// <inheritdoc />
    public List<TicketResponse> GetTickets(TicketRequest request)
    {
        var tickets = unitOfWork.TicketRepository.GetTickets(request);
        return tickets.Select(x => new TicketResponse
        {
            TickedId = x.Id,
            Summary = x.Summary,
            Description = x.Description,
            Product = x.Product?.Name,
            Priority = x.Priority?.Name,
            Category = x.Category?.Name,
            Status = x.Status,
            RaisedBy = x.User?.Email,
            CreatedDate = x.RaisedDate,
            ExpectedDate = x.ExpectedDate
        }).ToList();
    }

    /// <inheritdoc />
    public TicketResponse? FindTicket(int ticketId)
    {
        var ticket = unitOfWork.Repository<Ticket>().GetById(ticketId);
        if (ticket is null) return null;

        return new TicketResponse
        {
            TickedId = ticket.Id,
            Summary = ticket.Summary,
            Description = ticket.Description,
            ProductId = ticket.ProductId,
            PriorityId = ticket.PriorityId,
            CategoryId = ticket.CategoryId,
            Status = ticket.Status,
            RaisedBy = ticket.User?.Email,
            CreatedDate = ticket.RaisedDate,
            ExpectedDate = ticket.ExpectedDate
        };
    }
}