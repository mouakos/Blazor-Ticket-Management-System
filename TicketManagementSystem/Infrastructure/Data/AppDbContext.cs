using Domain.Entities;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
{
    #region Public properties declaration

    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Discussion> Discussions { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Ticket> Ticket { get; set; }

    #endregion

    #region Protected methods declaration

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.GenerateSeed();

        builder.Entity<Ticket>()
            .HasOne(e => e.User)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Discussion>()
            .HasOne(m => m.Ticket)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }

    #endregion
}