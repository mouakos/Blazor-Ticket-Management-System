using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    #region Public methods declaration

    List<ChartResponse> ChartByCategory(string category);
    List<ChartResponse> GetSummary();
    Ticket? FindTicket(int ticketId);
    List<Ticket> GetTickets(TicketRequest? request);
    List<ChartResponse> Last12MonthTickets();

    #endregion
}