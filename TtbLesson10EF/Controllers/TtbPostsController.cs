using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TtbLesson10EF.Models;

namespace TtbLesson10EF.Controllers
{
    public class TtbPostsController : Controller
    {
        private readonly TtbLesson10Context _context;

        public TtbPostsController(TtbLesson10Context context)
        {
            _context = context;
        }

        // GET: TtbPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.TtbPosts.ToListAsync());
        }

        // GET: TtbPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttbPost = await _context.TtbPosts
                .FirstOrDefaultAsync(m => m.Ttbid == id);
            if (ttbPost == null)
            {
                return NotFound();
            }

            return View(ttbPost);
        }

        // GET: TtbPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TtbPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ttbid,TtbTitle,TtbImages,TtbContent,TtbStatus")] TtbPost ttbPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ttbPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ttbPost);
        }

        // GET: TtbPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttbPost = await _context.TtbPosts.FindAsync(id);
            if (ttbPost == null)
            {
                return NotFound();
            }
            return View(ttbPost);
        }

        // POST: TtbPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ttbid,TtbTitle,TtbImages,TtbContent,TtbStatus")] TtbPost ttbPost)
        {
            if (id != ttbPost.Ttbid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ttbPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TtbPostExists(ttbPost.Ttbid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ttbPost);
        }

        // GET: TtbPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttbPost = await _context.TtbPosts
                .FirstOrDefaultAsync(m => m.Ttbid == id);
            if (ttbPost == null)
            {
                return NotFound();
            }

            return View(ttbPost);
        }

        // POST: TtbPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ttbPost = await _context.TtbPosts.FindAsync(id);
            if (ttbPost != null)
            {
                _context.TtbPosts.Remove(ttbPost);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TtbPostExists(int id)
        {
            return _context.TtbPosts.Any(e => e.Ttbid == id);
        }
    }
}
