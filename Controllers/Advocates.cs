using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SamoraMachelChambersGroupOfAdvocates.Controllers
{
    public class Advocates : Controller
    {
        // GET: Advocates
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advocates/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Advocates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advocates/Create
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

        // GET: Advocates/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Advocates/Edit/5
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

        // GET: Advocates/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Advocates/Delete/5
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
