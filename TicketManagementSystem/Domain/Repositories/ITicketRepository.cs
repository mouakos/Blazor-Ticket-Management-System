using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    #region Public methods declaration

    Task<List<ChartResponse>> ChartByCategory(string category);
    Task<List<ChartResponse>> GetSummaryAsync();
    Task<Ticket?> FindTicketAsync(int ticketId);
    Task<List<Ticket>> GetTicketsAsync(TicketRequest? request);
    Task<List<ChartResponse>> GetLast12MonthTicketsAsync();

    #endregion
}