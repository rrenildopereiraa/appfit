using Appfit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appfit.Controllers
{
    public class GymsController : Controller
    {
        private readonly AppfitDbContext _context;

        public GymsController(AppfitDbContext context)
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
