using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DiscussionRepository(AppDbContext appDbContext)
    : GenericRepository<Discussion>(appDbContext), IDiscussionRepository
{
    #region Private fields declaration

    private readonly AppDbContext m_AppDbContext = appDbContext;

    #endregion

    #region Public methods declaration

    /// <inheritdoc />
    public List<Discussion> GetDiscussions(int ticketId)
    {
        return m_AppDbContext.Set<Discussion>()
            .Include(x => x.Attachments)
            .Include(x => x.User)
            .Where(x => x.TicketId == ticketId)
            .OrderBy(x => x.CreatedDate)
            .ToList();
    }

    #endregion
}