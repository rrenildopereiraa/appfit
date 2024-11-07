using Appfit.Models;
using Microsoft.EntityFrameworkCore;

namespace Appfit.Services
{
    public class AppfitDbContext : DbContext
    {
        public AppfitDbContext(DbContextOptions options) : base(options) { }
        public DbSet<AppfitUser> Clients { get; set; }
        public DbSet<AppfitGym> Gymnasiums { get; set; }
        public DbSet<AppfitSubscription> Subscriptions { get; set; }
    }
}
