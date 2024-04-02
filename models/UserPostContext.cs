using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class UserPostContext : DbContext
{
   public UserPostContext(DbContextOptions<UserPostContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
}