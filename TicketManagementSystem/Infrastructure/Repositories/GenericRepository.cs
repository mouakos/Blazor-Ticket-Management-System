using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<T>(AppDbContext appDbContext) : IGenericRepository<T> where T : class
{
    /// <inheritdoc />
    public async Task<T?> GetByIdAsync(int id)
    {
        return await appDbContext.Set<T>().FindAsync(id);
    }

    /// <inheritdoc />
    public async Task<List<T>> GetAllAsync()
    {
        return await appDbContext.Set<T>().ToListAsync();
    }

    /// <inheritdoc />
    public async Task AddAsync(T entity)
    {
        await appDbContext.Set<T>().AddAsync(entity);
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
    public async Task SaveChangesAsync()
    {
        await appDbContext.SaveChangesAsync();
    }
}