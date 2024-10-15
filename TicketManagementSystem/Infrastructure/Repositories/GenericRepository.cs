using Domain.Repositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<T>(IdentityDbContext appDbContext) : IGenericRepository<T> where T : class
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