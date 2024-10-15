using Bogus;
using Domain.Entities;
using Infrastructure.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions;

public static class Seed
{
    public static void GenerateSeed(this ModelBuilder modelBuilder)
    {
        var userId = Guid.NewGuid().ToString();
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

        var date = new DateTime(2024, 9, 1);

        var ticketId = 1;
        var testTickets = new Faker<Ticket>()
            .RuleFor(t => t.Id, _ => ticketId++)
            .RuleFor(t => t.RaisedBy, _ => userId)
            .RuleFor(t => t.CategoryId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.ProductId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.PriorityId, f => f.PickRandom(1, 2, 3))
            .RuleFor(t => t.Status, f => f.PickRandom("NEW", "OPEN", "CLOSED"))
            .RuleFor(t => t.Summary, _ => $"Sample ticket {ticketId}")
            .RuleFor(t => t.RaisedDate, _ => date.AddDays(1))
            .RuleFor(t => t.ExpectedDate, f => date.AddDays(f.PickRandom(1, 7, 14)))
            .RuleFor(t => t.Description, _ => $"Description for ticket {ticketId}");

        var tickets = testTickets.Generate(60);
        modelBuilder.Entity<Ticket>().HasData(tickets);
    }
}