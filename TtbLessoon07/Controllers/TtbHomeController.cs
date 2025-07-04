﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TtbLessoon07.Models;

namespace TtbLesson07.Controllers
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
