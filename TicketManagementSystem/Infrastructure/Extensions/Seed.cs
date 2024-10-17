using Bogus;
using Domain.Entities;
using Infrastructure.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions;

public static class Seed
{
    #region Public methods declaration

    public static void GenerateSeed(this ModelBuilder modelBuilder)
    {
        const string userId = "c5e57a7f-39e8-4007-940e-4468dfbb04f3";
        const string email = "test@gmail.com";

        // Create user
        var user = new User
        {
            Id = userId,
            Email = email,
            EmailConfirmed = true,
            UserName = email,
            NormalizedEmail = email.ToUpper(),
            NormalizedUserName = email.ToUpper()
        };

        // Set user password
        var ph = new PasswordHasher<User>();
        user.PasswordHash = ph.HashPassword(user, Constants.c_DefaultPassword);

        // seed user
        modelBuilder.Entity<User>().HasData(user);

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 1,
            Name = "Application Bug"
        }, new Category
        {
            Id = 2,
            Name = "Network Issue"
        }, new Category
        {
            Id = 3,
            Name = "User Issue"
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Name = "Product 1"
        }, new Product
        {
            Id = 2,
            Name = "Product 2"
        }, new Product
        {
            Id = 3,
            Name = "Product 3"
        });

        modelBuilder.Entity<Priority>().HasData(new Priority
        {
            Id = 1,
            Name = "Low",
            ExpectedDays = 14
        }, new Priority
        {
            Id = 2,
            Name = "Medium",
            ExpectedDays = 7
        }, new Priority
        {
            Id = 3,
            Name = "High",
            ExpectedDays = 1
        });

        var date = new DateOnly(2024, 10, 17);
        var startDate = new DateOnly(2024, 1, 1);
        var ticketId = 1;
        var testTickets = new Faker<Ticket>()
            .RuleFor(t => t.Id, _ => ticketId++)
            .RuleFor(t => t.RaisedBy, _ => userId)
            .RuleFor(t => t.CategoryId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.ProductId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.PriorityId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.Status,
                f => f.PickRandom(Constants.c_StatusNew, Constants.c_StatusOpen, Constants.c_StatusClosed))
            .RuleFor(t => t.Summary, _ => $"Sample ticket {ticketId}")
            .RuleFor(t => t.RaisedDate,
                f => f.Date.BetweenDateOnly(startDate, date).ToDateTime(TimeOnly.FromDateTime(DateTime.Now)))
            .RuleFor(t => t.ClosedBy, (_, t) => t.Status == Constants.c_StatusClosed ? userId : null)
            .RuleFor(t => t.ExpectedDate, (f, t) => t.RaisedDate.AddDays(f.PickRandom(1, 7, 14)))
            .RuleFor(t => t.ClosedDate, (_, t) => t.Status == Constants.c_StatusClosed ? t.ExpectedDate : null)
            .RuleFor(t => t.Description, _ => $"Description for ticket {ticketId}");

        var tickets = testTickets.Generate(60);
        modelBuilder.Entity<Ticket>().HasData(tickets);
    }

    #endregion
}