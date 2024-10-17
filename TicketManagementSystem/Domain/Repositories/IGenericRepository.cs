namespace Domain.Repositories;

public interface IGenericRepository<T> where T : class
{
    #region Public methods declaration

    void Add(T entity);
    void Delete(T entity);
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    void Update(T entity);

    #endregion
}