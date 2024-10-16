namespace Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    #region Public properties declaration

    ITicketRepository TicketRepository { get; }

    #endregion

    #region Public methods declaration

    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> SaveChanges();
    Task<bool> SaveChangesReturnBool();

    #endregion
}