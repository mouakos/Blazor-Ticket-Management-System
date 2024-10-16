namespace Domain.Repositories;

public interface IGenericRepository<T> where T : class
{
    #region Public methods declaration

    void Add(T entity);
    void Delete(T entity);
    List<T> GetAll();
    T? GetById(int id);
    void SaveChanges();
    void Update(T entity);

    #endregion
}