using KseniiaIllustrator.Models;
using Microsoft.EntityFrameworkCore;

namespace KseniiaIllustrator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
