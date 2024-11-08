using Appfit.Models;
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
            var gyms = _context.Gyms.OrderByDescending(g => g.Id).ToList();
            return View(gyms);
        }

        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(GymDto gymDto)
        {
            if (gymDto.ImageFile == null) {
                ModelState.AddModelError("ImageFile", "The image file is required");
            }

            if (!ModelState.IsValid)
            {
                return View(gymDto);
            }

            return RedirectToAction("Index", "Gyms");
        }
    }
}
