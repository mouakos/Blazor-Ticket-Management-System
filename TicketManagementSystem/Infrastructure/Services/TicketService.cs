using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Infrastructure.Services;

public class TicketService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : ITicketService
{
    /// <inheritdoc />
    public List<TicketResponse> GetTickets(TicketRequest? request = null)
    {
        var tickets = unitOfWork.TicketRepository.GetTickets(request);
        return tickets.Select(x => new TicketResponse
        {
            TicketId = x.Id,
            Summary = x.Summary,
            Description = x.Description,
            Product = x.Product?.Name,
            Priority = x.Priority?.Name,
            Category = x.Category?.Name,
            Status = x.Status,
            RaisedBy = x.User?.Email,
            CreatedDate = x.RaisedDate,
            ExpectedDate = x.ExpectedDate
        }).ToList();
    }

    /// <inheritdoc />
    public TicketResponse? FindTicket(int ticketId)
    {
        var ticket = unitOfWork.Repository<Ticket>().GetById(ticketId);
        if (ticket is null) return null;

        return new TicketResponse
        {
            TicketId = ticket.Id,
            Summary = ticket.Summary,
            Description = ticket.Description,
            ProductId = ticket.ProductId,
            PriorityId = ticket.PriorityId,
            CategoryId = ticket.CategoryId,
            AssignedToId = ticket.AssignedToId,
            Status = ticket.Status,
            RaisedBy = ticket.User?.Id,
            RaisedByName = ticket.User?.Email,
            CreatedDate = ticket.RaisedDate,
            ExpectedDate = ticket.ExpectedDate
        };
    }

    /// <inheritdoc />
    public async Task<BaseResponse> UpdateTicketAsync(UpdateTicketRequest request)
    {
        var baseResponse = new BaseResponse { IsSuccess = false };
        var currentTicket = unitOfWork.TicketRepository.GetById(request.TicketId);
        if (currentTicket is null)
        {
            baseResponse.ErrorMessage = "Ticket not found!";
            return baseResponse;
        }

        currentTicket.ProductId = request.ProductId.Value;
        currentTicket.CategoryId = request.CategoryId.Value;
        currentTicket.PriorityId = request.PriorityId.Value;
        currentTicket.AssignedToId = request.AssignedToId;

        currentTicket.Status = request.Status;
        currentTicket.LastUpdateDate = DateTime.Now;

        if (request.Status == Constants.c_StatusClosed)
        {
            currentTicket.ClosedDate = DateTime.Now;
            var currentUser = httpContextAccessor.HttpContext?.User.Claims
                .FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            if (currentUser == null)
            {
                baseResponse.ErrorMessage = "User is not valid, please re-login";
                return baseResponse;
            }

            currentTicket.ClosedBy = currentUser;
        }

        unitOfWork.TicketRepository.Update(currentTicket);
        var dbResult = await unitOfWork.SaveChangesReturnBool();
        if (dbResult)
        {
            baseResponse.IsSuccess = true;
        }
        else
        {
            baseResponse.ErrorMessage = "Failed when saving to database! Try again later.";
        }

        return baseResponse;
    }
}