using Appfit.Models;
using Appfit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appfit.Controllers
{
    public class GymsController : Controller
    {
        private readonly AppfitDbContext _context;
        private readonly IWebHostEnvironment _env;

        public GymsController(AppfitDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

            // save the image file
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            newFileName += Path.GetExtension(gymDto.ImageFile!.FileName);

            string imageFullPath = _env.WebRootPath + "/public/assets/gyms/" + newFileName;
            using (var stream = System.IO.File.Create(imageFullPath))
            {
                gymDto.ImageFile.CopyTo(stream);
            }

            // save the new gym in the database
            GymViewModel gym = new GymViewModel()
            {
                LocationName = gymDto.LocationName,
                Address = gymDto.Address,
                Phone = gymDto.Phone,
                OpeningHours = gymDto.OpeningHours
            };

            _context.Gyms.Add(gym);
            _context.SaveChanges();

            return RedirectToAction("Index", "Gyms");
        }
    }
}
