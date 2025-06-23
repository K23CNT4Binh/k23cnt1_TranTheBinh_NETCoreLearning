using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TtbLesson09.Models;
namespace TtbLesson09.Controllers
{
    public class TtbCategoriesController : Controller

    {
        private readonly TtbBookStoreContext _context;

        public TtbCategoriesController(TtbBookStoreContext context)
        {
            _context = context;
        }

        // GET: TtbCategories
        public async Task<IActionResult> TtbIndex()
        {
            
            return View(await _context.Categories.ToListAsync());
        }

        // GET: TtbCategories/Details/5
        public async Task<IActionResult> TtbDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: TtbCategories/Create
        public IActionResult TtbCreate()
        {
            var ttbCategory = new Category();
            return View(ttbCategory);
        }

        // POST: TtbCategories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbCreate([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TtbIndex));
            }
            return View(category);
        }

        // GET: TtbCategories/Edit/5
        public async Task<IActionResult> TtbEdit(int? ttbId)
        {
            if (ttbId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(ttbId);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: TtbCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbEdit(int ttbId, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (ttbId != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TtbIndex));
            }
            return View(category);
        }

        // GET: TtbCategories/Delete/5
        public async Task<IActionResult> TtbDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: TtbCategories/Delete/5
        [HttpPost, ActionName("TtbDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TtbDeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(TtbIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
