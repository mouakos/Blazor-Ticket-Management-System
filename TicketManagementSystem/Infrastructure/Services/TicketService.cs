using System.Security.Claims;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services;

public class TicketService(
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor,
    IWebHostEnvironment webHostEnvironment) : ITicketService
{
    #region Public methods declaration

    /// <inheritdoc />
    public async Task<BaseResponse<int>> CreateTicketAsync(CreateTicketRequest request)
    {
        var createTicketResult = new BaseResponse<int> { IsSuccess = false };
        var uploadPath = Path.Combine(webHostEnvironment.WebRootPath, "uploads", "attachments");

        try
        {
            var currentUser = httpContextAccessor.HttpContext?.User.Claims
                .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)
                ?.Value;
            if (currentUser == null)
            {
                createTicketResult.ErrorMessage = "User is not valid, please re-login";
                return createTicketResult;
            }

            var ticket = new Ticket
            {
                Summary = request.Summary,
                Description = request.Description,
                ProductId = request.ProductId.Value,
                CategoryId = request.CategoryId.Value,
                PriorityId = request.PriorityId.Value,
                AssignedToId = request.AssignedToId,
                RaisedBy = currentUser,
                RaisedDate = DateTime.Now,
                Status = Constants.c_StatusNew
            };

            var priority = unitOfWork.Repository<Priority>().GetById(request.PriorityId.Value);
            if (priority != null) ticket.ExpectedDate = DateTime.Now.AddDays(priority.ExpectedDays);

            unitOfWork.TicketRepository.Add(ticket);

            if (request.Files is { Count: > 0 })
                foreach (var file in request.Files)
                {
                    var fileExt = Path.GetExtension(file.Name);
                    var actualName = Path.GetFileNameWithoutExtension(file.Name);

                    var fileName = $"{actualName}-{Guid.NewGuid().ToString()}{fileExt}";
                    var filePath = Path.Combine(uploadPath, fileName);

                    await using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.OpenReadStream().CopyToAsync(fileStream);
                    }

                    var attachment = new Attachment
                    {
                        Ticket = ticket,
                        FileName = Path.GetFileName(file.Name),
                        ServerFileName = fileName,
                        FileSize = file.Size,
                        CreatedDate = DateTime.Now
                    };
                    unitOfWork.Repository<Attachment>().Add(attachment);
                }

            var result = await unitOfWork.SaveChangesReturnBool();

            if (result)
            {
                createTicketResult.IsSuccess = true;
                createTicketResult.Value = ticket.Id;
            }
            else
            {
                createTicketResult.ErrorMessage = "Failed when create ticket!";
            }

            return createTicketResult;
        }
        catch (Exception ex)
        {
            createTicketResult.ErrorMessage = "Failed: " + ex.Message;
            return createTicketResult;
        }
    }

    /// <inheritdoc />
    public TicketResponse? FindTicket(int ticketId)
    {
        var ticket = unitOfWork.Repository<Ticket>().GetById(ticketId);
        if (ticket is null) return null;

        var attachments = unitOfWork.Repository<Attachment>().GetAll().Where(x => x.TicketId == ticket.Id).ToList();

        var attachmentPath = Path.Combine("uploads", "attachments");
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
            ExpectedDate = ticket.ExpectedDate,
            ClosedBy = ticket.ClosedBy,
            ClosedDate = ticket.ClosedDate,
            Attachments = attachments.Select(x => new AttachmentResponse
            {
                FileName = x.FileName,
                ServerFileName = Path.Combine(attachmentPath, x.ServerFileName)
            }).ToList()
        };
    }

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
            baseResponse.IsSuccess = true;
        else
            baseResponse.ErrorMessage = "Failed when saving to database! Try again later.";

        return baseResponse;
    }

    /// <inheritdoc />
    public List<ChartResponse> Last12MonthTickets()
    {
        return unitOfWork.TicketRepository.Last12MonthTickets();
    }

    /// <inheritdoc />
    public List<ChartResponse> ChartByCategory(string category)
    {
        return unitOfWork.TicketRepository.ChartByCategory(category);
    }

    /// <inheritdoc />
    public List<ChartResponse> GetSummary()
    {
        return unitOfWork.TicketRepository.GetSummary();
    }

    #endregion
}