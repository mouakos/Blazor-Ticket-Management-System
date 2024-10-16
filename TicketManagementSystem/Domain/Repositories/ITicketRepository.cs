using Domain.DTOs.Requests;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    #region Public methods declaration

    List<Ticket> GetTickets(TicketRequest? request);

    #endregion
}