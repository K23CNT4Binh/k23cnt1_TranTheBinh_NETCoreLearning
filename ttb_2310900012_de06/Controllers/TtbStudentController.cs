using Microsoft.AspNetCore.Mvc;
using ttb_2310900012_de06.Models;

namespace ttb_2310900012_de06.Controllers
{
    public class TtbStudentController : Controller
    {
        private readonly TtbDbContext _context;

        public TtbStudentController(TtbDbContext context)
        {
            _context = context;
        }

        // 1. Hiển thị danh sách
        public IActionResult TtbIndex()
        {
            var list = _context.TtbStudents.ToList();
            return View(list);
        }

        // 2. Thêm mới - GET
        public IActionResult TtbCreate()
        {
            return View();
        }

        // 2. Thêm mới - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TtbCreate(TtbStudent sv)
        {
            if (ModelState.IsValid)
            {
                _context.TtbStudents.Add(sv);
                _context.SaveChanges();
                return RedirectToAction("TtbIndex");
            }
            return View(sv);
        }

        // 3. Xem chi tiết
        public IActionResult TtbDetails(int id)
        {
            var sv = _context.TtbStudents.Find(id);
            if (sv == null) return NotFound();
            return View(sv);
        }

        // 4. Sửa - GET
        public IActionResult TtbEdit(int id)
        {
            var sv = _context.TtbStudents.Find(id);
            if (sv == null) return NotFound();
            return View(sv);
        }

        // 4. Sửa - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TtbEdit(int id, TtbStudent sv)
        {
            if (id != sv.TtbStudId) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(sv);
                _context.SaveChanges();
                return RedirectToAction("TtbIndex");
            }
            return View(sv);
        }

        // 5. Xóa - GET
        public IActionResult TtbDelete(int id)
        {
            var sv = _context.TtbStudents.Find(id);
            if (sv == null) return NotFound();
            return View(sv);
        }

        // 5. Xóa - POST
        [HttpPost, ActionName("TtbDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult TtbDeleteConfirmed(int id)
        {
            var sv = _context.TtbStudents.Find(id);
            if (sv != null)
            {
                _context.TtbStudents.Remove(sv);
                _context.SaveChanges();
            }
            return RedirectToAction("TtbIndex");
        }
    }
}
