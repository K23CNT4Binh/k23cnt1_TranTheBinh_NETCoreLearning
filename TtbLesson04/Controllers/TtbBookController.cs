using Microsoft.AspNetCore.Mvc;
using TtbLesson04.Models;
using System.Collections.Generic;

namespace TtbLesson04.Controllers
{
    public class TtbBookController : Controller
    {
        private List<TtbBook> ttbBooks = new List<TtbBook>
        {
            new TtbBook
            {
                TtbId = "001",
                TtbTitle = "Lập trình cơ bản",
                TtbDescription = "Cuốn sách cho người mới bắt đầu học lập trình.",
                TtbImage = "/images/book-1.png",
                TtbPrice = 120000,
                TtbPage = 350
            },
            new TtbBook
            {
                TtbId = "002",
                TtbTitle = "Cấu trúc dữ liệu",
                TtbDescription = "Hiểu cách tổ chức và truy xuất dữ liệu.",
                TtbImage = "/images/book-2.jpg",
                TtbPrice = 150000,
                TtbPage = 420
            },
            new TtbBook
            {
                TtbId = "003",
                TtbTitle = "Thuật toán nâng cao",
                TtbDescription = "Khám phá các thuật toán tối ưu và ứng dụng thực tế.",
                TtbImage = "/images/book-3.jpg",
                TtbPrice = 180000,
                TtbPage = 500
            },
            new TtbBook
            {
                TtbId = "004",
                TtbTitle = "C# cho người mới bắt đầu",
                TtbDescription = "Hướng dẫn lập trình C# từ cơ bản đến nâng cao.",
                TtbImage = "/images/book-4.jpg",
                TtbPrice = 135000,
                TtbPage = 320
            },
            new TtbBook
            {
                TtbId = "005",
                TtbTitle = "ASP.NET Core Web Development",
                TtbDescription = "Xây dựng ứng dụng web mạnh mẽ với ASP.NET Core.",
                TtbImage = "/images/book-5.jpg",
                TtbPrice = 210000,
                TtbPage = 480
            },
          
        };

        // GET: TtbBook/TtbIndex
        public IActionResult TtbIndex()
        {
            //dua du lieu len view
            return View(ttbBooks);
        }
    }
}
