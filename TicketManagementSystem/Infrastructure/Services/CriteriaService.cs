using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;

namespace Infrastructure.Services;

public class CriteriaService(IUnitOfWork unitOfWork) : ICriteriaService
{
    #region Public methods declaration

    /// <inheritdoc />
    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await unitOfWork.Repository<Category>().GetAllAsync();
    }

    /// <inheritdoc />
    public async Task<List<Priority>> GetPrioritiesAsync()
    {
        return await unitOfWork.Repository<Priority>().GetAllAsync();
    }

    /// <inheritdoc />
    public async Task<List<Product>> GetProductsAsync()
    {
        return await unitOfWork.Repository<Product>().GetAllAsync();
    }

    /// <inheritdoc />
    public async Task<List<string>> GetStatusAsync()
    {
        List<string> status =
        [
            "NEW",
            "OPEN",
            "CLOSED"
        ];
        return await Task.FromResult(status);
    }

    #endregion
}