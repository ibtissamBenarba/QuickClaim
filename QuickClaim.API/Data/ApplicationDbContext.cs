using Microsoft.EntityFrameworkCore;
using QuickClaim.API.Models;

namespace QuickClaim.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
