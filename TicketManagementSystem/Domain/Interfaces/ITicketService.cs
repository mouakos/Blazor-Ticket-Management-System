using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface ITicketService
{
    #region Public methods declaration

    List<ChartResponse> ChartByCategory(string category);

    Task<BaseResponse<int>> CreateTicketAsync(CreateTicketRequest request);
    TicketResponse? FindTicket(int ticketId);
    List<ChartResponse> GetSummary();
    List<TicketResponse> GetTickets(TicketRequest? request = null);

    List<ChartResponse> Last12MonthTickets();
    Task<BaseResponse> UpdateTicketAsync(UpdateTicketRequest request);

    #endregion
}