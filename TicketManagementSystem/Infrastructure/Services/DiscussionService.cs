﻿using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace Infrastructure.Services;

public class DiscussionService(
    IUnitOfWork unitOfWork,
    IAccountService accountService,
    IWebHostEnvironment environment,
    IDiscussionRepository discussionRepository) : IDiscussionService
{
    #region Public methods declaration

    /// <inheritdoc />
    public async Task<BaseResponse> Create(DiscussionRequest request)
    {
        var response = new BaseResponse
        {
            IsSuccess = false
        };
        var uploadPath = Path.Combine(environment.WebRootPath, "uploads", "attachments");

        var currentUser = await accountService.GetCurrentUserAsync();
        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        var discussion = new Discussion
        {
            CreatedDate = DateTime.Now,
            Message = request.Message,
            TicketId = request.TicketId,
            UserId = currentUser.Value?.Id
        };

        unitOfWork.DiscussionRepository.Add(discussion);

        if (request.Attachments is { Count: > 0 })
            foreach (var file in request.Attachments)
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
                    Discussion = discussion,
                    FileName = Path.GetFileName(file.Name),
                    ServerFileName = fileName,
                    FileSize = file.Size,
                    CreatedDate = DateTime.Now
                };
                unitOfWork.Repository<Attachment>().Add(attachment);
            }

        var result = await unitOfWork.SaveChangesReturnBool();

        if (result)
            response.IsSuccess = true;
        else
            response.ErrorMessage = "Failed when create discussion!";

        return response;
    }

    /// <inheritdoc />
    public List<DiscussionResponse> GetDiscussions(int ticketId)
    {
        var uploadPath = Path.Combine("uploads", "attachments");

        var result = discussionRepository.GetDiscussions(ticketId);

        return result.Select(x => new DiscussionResponse
        {
            Message = x.Message,
            CreatedDate = x.CreatedDate,
            User = x.User,
            Attachments = x.Attachments?.Select(a => new AttachmentResponse
            {
                FileName = a.FileName,
                ServerFileName = Path.Combine(uploadPath, a.ServerFileName)
            }).ToList()
        }).ToList();
    }

    #endregion
}