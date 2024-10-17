using System.Collections;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public sealed class UnitOfWork(
    AppDbContext appDbContext,
    ITicketRepository ticketRepository,
    IDiscussionRepository discussionRepository) : IUnitOfWork
{
    #region Private fields declaration

    private Hashtable? m_Repositories;

    #endregion

    #region Public properties declaration

    /// <inheritdoc />
    public IDiscussionRepository DiscussionRepository => discussionRepository;

    /// <inheritdoc />
    public ITicketRepository TicketRepository => ticketRepository;

    #endregion

    #region Public methods declaration

    /// <inheritdoc />
    public void Dispose()
    {
        appDbContext.Dispose();
    }

    /// <inheritdoc />
    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        m_Repositories ??= new Hashtable();
        var type = typeof(TEntity).Name;
        if (m_Repositories.ContainsKey(type)) return (IGenericRepository<TEntity>)m_Repositories[type]!;
        var repositoryType = typeof(GenericRepository<>);
        var repositoryInstance =
            Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), appDbContext);
        m_Repositories.Add(type, repositoryInstance);

        return (IGenericRepository<TEntity>)m_Repositories[type]!;
    }


    /// <inheritdoc />
    public async Task<bool> SaveChangesAsync()
    {
        return await appDbContext.SaveChangesAsync() > 0;
    }

    #endregion
}