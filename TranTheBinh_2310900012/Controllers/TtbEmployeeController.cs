using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TranTheBinh_2310900012.Data;
using TranTheBinh_2310900012.Models;

namespace TranTheBinh_2310900012.Controllers
{
    public class TtbEmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public TtbEmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /TtbEmployee/TtbIndex
        public async Task<IActionResult> TtbIndex()
        {
            return View(await _context.TtbEmployees.ToListAsync());
        }

        // GET: /TtbEmployee/TtbCreate
        public IActionResult TtbCreate()
        {
            return View();
        }

        // POST: /TtbEmployee/TtbCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbCreate(TtbEmployee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TtbIndex));
            }
            return View(employee);
        }

        // GET: /TtbEmployee/TtbEdit/5
        public async Task<IActionResult> TtbEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.TtbEmployees.FindAsync(id);
            if (employee == null)
                return NotFound();

            return View(employee);
        }

        // POST: /TtbEmployee/TtbEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbEdit(int id, TtbEmployee employee)
        {
            if (id != employee.TtbEmpId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TtbEmployees.Any(e => e.TtbEmpId == id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(TtbIndex));
            }
            return View(employee);
        }

        // GET: /TtbEmployee/TtbDetails/5
        public async Task<IActionResult> TtbDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.TtbEmployees.FirstOrDefaultAsync(e => e.TtbEmpId == id);
            if (employee == null)
                return NotFound();

            return View(employee);
        }

        // GET: /TtbEmployee/TtbDelete/5
        public async Task<IActionResult> TtbDelete(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.TtbEmployees.FirstOrDefaultAsync(e => e.TtbEmpId == id);
            if (employee == null)
                return NotFound();

            return View(employee);
        }

        // POST: /TtbEmployee/TtbDelete/5
        [HttpPost, ActionName("TtbDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbDeleteConfirmed(int id)
        {
            var employee = await _context.TtbEmployees.FindAsync(id);
            if (employee != null)
            {
                _context.TtbEmployees.Remove(employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(TtbIndex));
        }
    }
}
