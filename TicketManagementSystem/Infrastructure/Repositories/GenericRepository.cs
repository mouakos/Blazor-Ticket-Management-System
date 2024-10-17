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
    public async Task<List<T>> GetAllAsync()
    {
        return await appDbContext.Set<T>().AsNoTracking().ToListAsync();
    }

    /// <inheritdoc />
    public async Task<T?> GetByIdAsync(int id)
    {
        return await appDbContext.Set<T>().FindAsync(id);
    }

    /// <inheritdoc />
    public void Update(T entity)
    {
        appDbContext.Set<T>().Update(entity);
    }

    #endregion
}