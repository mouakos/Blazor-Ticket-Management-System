using Domain.DTOs.Requests;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    List<Ticket> GetTickets(TicketRequest? request);
}