using Appfit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Appfit.Services
{
    public class AppfitContext : DbContext
    {
        public AppfitContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppfitUser> Clients { get; set; }
        public DbSet<AppfitGym> Gymnasiums { get; set; }
        public DbSet<AppfitSubscription> Subscriptions { get; set; }
    }
}
