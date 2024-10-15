using Domain.Entities;

namespace Domain.Interfaces;

public interface ICriteriaService
{
    List<Category> GetCategories();
    List<Product> GetProducts();
    List<Priority> GetPriority();
    List<string> GetStatus();
}