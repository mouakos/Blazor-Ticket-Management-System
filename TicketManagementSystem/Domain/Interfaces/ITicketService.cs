using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface ITicketService
{
    #region Public methods declaration

    Task<List<ChartResponse>> ChartByCategory(string category);

    Task<BaseResponse<int>> CreateTicketAsync(CreateTicketRequest request);
    Task<TicketResponse?> FindTicketAsync(int ticketId);
    Task<List<ChartResponse>> GetSummaryAsync();
    Task<List<TicketResponse>> GetTicketsAsync(TicketRequest? request = null);
    Task<BaseResponse> DeleteTicketAsync(int ticketId);
    Task<List<ChartResponse>> GetLast12MonthTicketsAsync();
    Task<BaseResponse> UpdateTicketAsync(UpdateTicketRequest request);

    #endregion
}