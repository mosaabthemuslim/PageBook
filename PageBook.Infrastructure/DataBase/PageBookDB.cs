using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PageBook.Domain.Entities;

namespace PageBook.Infrastructure.DataBase;

public class PageBookDbContext : IdentityDbContext<User>
{
    public PageBookDbContext(DbContextOptions<PageBookDbContext> options)
        : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);



        modelBuilder.Entity<User>()
           .HasMany(u => u.Posts)
           .WithOne()
           .HasForeignKey(p => p.UserId)
           .OnDelete(DeleteBehavior.Cascade);




    }
}
