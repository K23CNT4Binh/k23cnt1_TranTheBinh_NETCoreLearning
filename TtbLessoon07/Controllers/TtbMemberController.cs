using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TtbLesson07.Controllers
{
    public class TtbMemberController : Controller
    {
        // GET: TtbMemberController
        public ActionResult TtbIndex()
        {
            return View();
        }

        // GET: TtbMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TtbMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TtbMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TtbIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TtbMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TtbMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TtbIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TtbMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TtbMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TtbIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
