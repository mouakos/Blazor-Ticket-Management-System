using Domain.DTOs.Requests;
using Domain.DTOs.Responses;

namespace Domain.Interfaces;

public interface IDiscussionService
{
    #region Public methods declaration

    Task<BaseResponse> Create(DiscussionRequest request);
    List<DiscussionResponse> GetDiscussions(int ticketId);

    #endregion
}