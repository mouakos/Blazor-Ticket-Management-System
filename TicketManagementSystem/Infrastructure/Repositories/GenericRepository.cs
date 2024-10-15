using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

// Todo: Use async methods?

public class GenericRepository<T>(AppDbContext appDbContext) : IGenericRepository<T> where T : class
{
    /// <inheritdoc />
    public T? GetById(int id)
    {
        return appDbContext.Set<T>().Find(id);
    }

    /// <inheritdoc />
    public List<T> GetAll()
    {
        return appDbContext.Set<T>().ToList();
    }

    /// <inheritdoc />
    public void Add(T entity)
    {
        appDbContext.Set<T>().Add(entity);
    }

    /// <inheritdoc />
    public void Update(T entity)
    {
        appDbContext.Set<T>().Attach(entity);
        appDbContext.Entry(entity).State = EntityState.Modified;
    }

    /// <inheritdoc />
    public void Delete(T entity)
    {
        appDbContext.Set<T>().Remove(entity);
    }

    /// <inheritdoc />
    public void SaveChanges()
    {
        appDbContext.SaveChanges();
    }
}