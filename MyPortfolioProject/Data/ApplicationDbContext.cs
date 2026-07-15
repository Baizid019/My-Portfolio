using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}