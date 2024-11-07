using Appfit.Models;
using Microsoft.EntityFrameworkCore;

namespace Appfit.Services
{
    public class AppfitDbContext : DbContext
    {
        public AppfitDbContext(DbContextOptions options) : base(options) { }

        public DbSet<BookingViewModel> Bookings { get; set; }
        public DbSet<ClassViewModel> Classes { get; set; }
        public DbSet<GymViewModel> Gymnasiums { get; set; }
        public DbSet<SubscriptionViewModel> Subscriptions { get; set; }
        public DbSet<UserViewModel> Users { get; set; }
    }
}
