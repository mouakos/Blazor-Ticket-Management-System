using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface ITicketService
{
    List<TicketResponse> GetTickets(TicketRequest request);

    TicketResponse? FindTicket(int ticketId);
}