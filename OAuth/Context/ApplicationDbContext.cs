using Microsoft.EntityFrameworkCore;
using OAuth.Models;

namespace OAuth.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>()
                .HasOne(u => u.TodoList)
                .WithOne(t => t.User)
                .HasForeignKey<TodoList>(t => t.UserId);

            modelBuilder.Entity<TodoList>()
                .HasOne(t => t.User)
                .WithOne(u => u.TodoList)
                .HasForeignKey<User>(u => u.Id);
        }
    }
}
