using Appfit.Models;
using Microsoft.EntityFrameworkCore;

namespace Appfit.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}
