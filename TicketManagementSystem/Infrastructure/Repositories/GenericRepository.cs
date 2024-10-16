using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

// Todo: Use async methods?

public class GenericRepository<T>(AppDbContext appDbContext) : IGenericRepository<T> where T : class
{
    #region Public methods declaration

    /// <inheritdoc />
    public void Add(T entity)
    {
        appDbContext.Set<T>().Add(entity);
    }

    /// <inheritdoc />
    public void Delete(T entity)
    {
        appDbContext.Set<T>().Remove(entity);
    }

    /// <inheritdoc />
    public List<T> GetAll()
    {
        return appDbContext.Set<T>().ToList();
    }

    /// <inheritdoc />
    public T? GetById(int id)
    {
        return appDbContext.Set<T>().Find(id);
    }

    /// <inheritdoc />
    public void SaveChanges()
    {
        appDbContext.SaveChanges();
    }

    /// <inheritdoc />
    public void Update(T entity)
    {
        appDbContext.Set<T>().Attach(entity);
        appDbContext.Entry(entity).State = EntityState.Modified;
    }

    #endregion
}