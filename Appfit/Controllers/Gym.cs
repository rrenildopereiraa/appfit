using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appfit.Controllers
{
    public class Gym : Controller
    {
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gym/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gym/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gym/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Gym/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gym/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Gym/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gym/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
