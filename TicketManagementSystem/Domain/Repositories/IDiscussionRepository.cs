using Domain.Entities;

namespace Domain.Repositories;

public interface IDiscussionRepository : IGenericRepository<Discussion>
{
    #region Public methods declaration

    Task<List<Discussion>> GetDiscussionsAsync(int ticketId);

    #endregion
}