namespace Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    ITicketRepository TicketRepository { get; }
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    int SaveChanges();
    bool SaveChangesReturnBool();
}