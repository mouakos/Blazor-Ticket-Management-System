using Domain.Entities;

namespace Domain.Interfaces;

public interface ICriteriaService
{
    #region Public methods declaration

    Task<List<Category>> GetCategoriesAsync();
    Task<List<Priority>> GetPrioritiesAsync();
    Task<List<Product>> GetProductsAsync();
    Task<List<string>> GetStatusAsync();

    #endregion
}