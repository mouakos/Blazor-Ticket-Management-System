namespace Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    #region Public properties declaration

    IDiscussionRepository DiscussionRepository { get; }

    ITicketRepository TicketRepository { get; }

    #endregion

    #region Public methods declaration

    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<bool> SaveChangesAsync();

    #endregion
}