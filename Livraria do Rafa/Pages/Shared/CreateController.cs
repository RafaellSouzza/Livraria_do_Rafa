using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_do_Rafa.Pages.Shared
{
    public class CreateController : Controller
    {
        // GET: CreateController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateController/Create
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

        // GET: CreateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateController/Edit/5
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

        // GET: CreateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateController/Delete/5
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
