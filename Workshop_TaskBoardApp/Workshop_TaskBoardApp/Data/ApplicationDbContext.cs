using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Workshop_TaskBoardApp.Data.Models;
using Task = Workshop_TaskBoardApp.Data.Models.Task;

namespace Workshop_TaskBoardApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Board> Boards { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Task>()
                .HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoadrId)
                .OnDelete(DeleteBehavior.Restrict);
                
                

            base.OnModelCreating(builder);
        }
    }
}