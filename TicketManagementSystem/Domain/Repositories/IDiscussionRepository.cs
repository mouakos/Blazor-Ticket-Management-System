using Domain.Entities;

namespace Domain.Repositories;

public interface IDiscussionRepository : IGenericRepository<Discussion>
{
    #region Public methods declaration

    List<Discussion> GetDiscussions(int ticketId);

    #endregion
}