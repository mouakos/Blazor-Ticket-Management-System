using Domain.Entities;

namespace Domain.Interfaces;

public interface ICriteriaService
{
    #region Public methods declaration

    List<Category> GetCategories();
    List<Priority> GetPriorities();
    List<Product> GetProducts();
    List<string> GetStatus();

    #endregion
}