using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kahve_Sipariş_Proje.Controllers
{
    public class Kahveler : Controller
    {
        // GET: Kahveler
        public ActionResult KahveMenu()
        {

            return View();
        }

        // GET: Kahveler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kahveler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kahveler/Create
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

        // GET: Kahveler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kahveler/Edit/5
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

        // GET: Kahveler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kahveler/Delete/5
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
