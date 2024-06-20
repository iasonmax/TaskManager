using Microsoft.EntityFrameworkCore;
using TaskManagerWeb.Models;

namespace TaskManagerWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Work", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Hobby", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Self Improvment", DisplayOrder = 3 }
                );
        }
    }
}
