using Domain.DTOs.Requests;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TicketRepository(AppDbContext appDbContext)
    : GenericRepository<Ticket>(appDbContext), ITicketRepository
{
    #region Private fields declaration

    private readonly AppDbContext m_AppDbContext = appDbContext;

    #endregion

    #region Public methods declaration

    /// <inheritdoc />
    public List<Ticket> GetTickets(TicketRequest? request)
    {
        IQueryable<Ticket> query = m_AppDbContext.Set<Ticket>()
            .Include(x => x.Category)
            .Include(x => x.Priority)
            .Include(x => x.Product)
            .Include(x => x.User)
            .Include(x => x.AssignedTo);

        if (request is null) return query.ToList();

        if (!string.IsNullOrWhiteSpace(request.Summary))
            query = query.Where(x => EF.Functions.Like(x.Summary, $"%{request.Summary}%"));

        if (request is { ProductId: not null, ProductId.Length: > 0 })
            query = query.Where(x => request.ProductId.Contains(x.ProductId));

        if (request is { CategoryId: not null, CategoryId.Length: > 0 })
            query = query.Where(x => request.CategoryId.Contains(x.CategoryId));

        if (request is { PriorityId: not null, PriorityId.Length: > 0 })
            query = query.Where(x => request.PriorityId.Contains(x.PriorityId));

        if (request is { Status: not null, Status.Length: > 0 })
            query = query.Where(x => request.Status.Contains(x.Status));

        if (request is { RaisedBy: not null, RaisedBy.Length: > 0 })
            query = query.Where(x => request.RaisedBy.Contains(x.RaisedBy));

        return query.OrderByDescending(x => x.RaisedDate).ToList();
    }

    #endregion
}