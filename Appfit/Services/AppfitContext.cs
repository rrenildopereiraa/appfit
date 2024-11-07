using Appfit.Models;
using Microsoft.EntityFrameworkCore;

namespace Appfit.Services
{
    public class AppfitContext : DbContext
    {
        public AppfitContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppfitUser> Clients { get; set; }
    }
}
