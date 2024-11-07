using Appfit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appfit.Controllers
{
    public class AppfitGym : Controller
    {
        private readonly AppfitDbContext _context;

        public AppfitGym(AppfitDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var gyms = _context.Gymnasiums.ToList();
            return View(gyms);
        }
    }
}
