using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface IDiscussionService
{
    #region Public methods declaration

    Task<BaseResponse> CreateDiscussionAsync(DiscussionRequest request);
    Task<List<DiscussionResponse>> GetDiscussionsAsync(int ticketId);

    #endregion
}