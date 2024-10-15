namespace Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    int SaveChanges();
    bool SaveChangesReturnBool();
}