using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    #region Public methods declaration

    List<Ticket> GetTickets(TicketRequest? request);
    List<ChartResponse> Last12MonthTickets();
    List<ChartResponse> ChartByCategory(string category);
    List<ChartResponse> GetSummary();

    #endregion
}