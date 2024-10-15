using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;

namespace Infrastructure.Services;

public class CriteriaService(IUnitOfWork unitOfWork) : ICriteriaService
{
    /// <inheritdoc />
    public List<Category> GetCategories()
    {
        return unitOfWork.Repository<Category>().GetAll();
    }

    /// <inheritdoc />
    public List<Product> GetProducts()
    {
        return unitOfWork.Repository<Product>().GetAll();
    }

    /// <inheritdoc />
    public List<Priority> GetPriority()
    {
        return unitOfWork.Repository<Priority>().GetAll();
    }

    /// <inheritdoc />
    public List<string> GetStatus()
    {
        return
        [
            "NEW",
            "OPEN",
            "CLOSED"
        ];
    }
}