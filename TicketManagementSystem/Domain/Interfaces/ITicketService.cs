using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface ITicketService
{
    #region Public methods declaration

    Task<BaseResponse<int>> CreateTicketAsync(CreateTicketRequest request);
    TicketResponse? FindTicket(int ticketId);
    List<TicketResponse> GetTickets(TicketRequest? request = null);
    Task<BaseResponse> UpdateTicketAsync(UpdateTicketRequest request);

    #endregion
}