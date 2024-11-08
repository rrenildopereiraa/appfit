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

        // GET: Gyms
        public IActionResult Index()
        {
            var gyms = _context.Gyms.OrderByDescending(g => g.Id).ToList();
            return View(gyms);
        }

        // GET: Gyms/Create
        public IActionResult Create() { 
            return View();
        }

        // POST: Gyms/Create
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

            string imageFullPath = _env.WebRootPath + "/locations/" + newFileName;
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
        
        // GET: Gyms/Edit
        public IActionResult Edit(int id)
        {
            var gym = _context.Gyms.Find(id);

            if (gym == null)
            {
                return RedirectToAction("Index", "Gyms");
            }

            // create gymDto from gym
            var gymDto = new GymDto()
            {
                LocationName = gym.LocationName,
                Address = gym.Address,
                Phone = gym.Phone,
                OpeningHours = gym.OpeningHours
            };

            ViewData["Id"] = gym.Id;
            ViewData["ImageFileName"] = gym.ImageFileName;

            return View(gymDto);
        }

        // POST: Gyms/Edit/{Id}
        [HttpPost]
        public IActionResult Edit(int id, GymDto gymDto)
        {
            var gym = _context.Gyms.Find(id);

            if (gym == null)
            {
                return RedirectToAction("Index", "Gyms");
            }

            if (!ModelState.IsValid)
            {
                ViewData["Id"] = gym.Id;
                ViewData["ImageFileName"] = gym.ImageFileName;

                return View(gymDto);
            }

            // update the image file if we have a new image file
            string newFileName = gym.ImageFileName;
            if (gymDto.ImageFile != null)
            {
                newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(gymDto.ImageFile.FileName);

                string imageFullPath = _env.WebRootPath + "/locations/" + newFileName;
                using (var stream = System.IO.File.Create(imageFullPath))
                {
                    gymDto.ImageFile.CopyTo(stream);
                }

                // delete the old image
                string oldImageFullPath = _env.WebRootPath + "/locations/" + gym.ImageFileName;
                System.IO.File.Delete(oldImageFullPath);
            }

            // update the product in the database
            gym.LocationName = gymDto.LocationName;
            gym.Address = gymDto.Address;
            gym.Phone = gymDto.Phone;
            gym.OpeningHours = gymDto.OpeningHours;

            _context.SaveChanges();

            return RedirectToAction("Index", "Gyms");
        }
    }
}
