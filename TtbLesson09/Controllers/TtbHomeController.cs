using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TtbLesson09.Models;

namespace TtbLesson09.Controllers
{
    public class TtbHomeController : Controller
    {
        private readonly ILogger<TtbHomeController> _logger;

        public TtbHomeController(ILogger<TtbHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TtbIndex()
        {
            return View();
        }

        public IActionResult TtbAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
