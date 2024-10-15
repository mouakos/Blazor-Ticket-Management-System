using System.Collections;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Repositories;

public class UnitOfWork(AppDbContext appDbContext) : IUnitOfWork
{
    private Hashtable? m_Repositories;

    /// <inheritdoc />
    public void Dispose()
    {
        appDbContext.Dispose();
    }

    /// <inheritdoc />
    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        m_Repositories ??= new Hashtable();
        var type = typeof(TEntity).Name;
        if (!m_Repositories.ContainsKey(type)) return (IGenericRepository<TEntity>)m_Repositories[type];
        var repositoryType = typeof(GenericRepository<>);
        var repositoryInstance =
            Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), appDbContext);
        m_Repositories.Add(type, repositoryInstance);

        return (IGenericRepository<TEntity>)m_Repositories[type];
    }

    /// <inheritdoc />
    public async Task<int> SaveChangesAsync()
    {
        return await appDbContext.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task<bool> SaveChangesReturnBool()
    {
        return await appDbContext.SaveChangesAsync() > 0;
    }
}