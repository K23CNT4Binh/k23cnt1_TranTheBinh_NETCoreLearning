using TtbLesson08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace TtbLesson08.Controllers
{
    public class TtbAccountController : Controller
    {
        // GET: TtbAccountController
        public ActionResult TtbIndex()
        {
            // Khởi tạo danh sách tài khoản
            List<TtbAccount> accounts = new List<TtbAccount>
            {
                new TtbAccount
                {
                    TtbId = 1,
                    TtbFullName = "Tran The Binh",
                    TtbEmail = "binhtranthe2005@gmail.com",
                    TtbPhone = "0978381287",
                    TtbAddress = "Bắc Giang",
                    TtbAvatar = "avatar1.jpg",
                    TtbBirthday = new DateTime(2005, 06, 27),
                    TtbGender = "Nam",
                    TtbPassword = "123456",
                    TtbFacebook = "https://facebook.com/TranTheBinh"

                },
                new TtbAccount
                {
                    TtbId = 2,
                    TtbFullName = "Trần Thị B",
                    TtbEmail = "b@gmail.com",
                    TtbPhone = "0912345678",
                    TtbAddress = "TP HCM",
                    TtbAvatar = "avatar2.jpg",
                    TtbBirthday = new DateTime(2001, 5, 15),
                    TtbGender = "Nữ",
                    TtbPassword = "abcdef",
                    TtbFacebook = "https://facebook.com/tranthib"
                },
                new TtbAccount
                {
                    TtbId = 3,
                    TtbFullName = "Lê Văn C",
                    TtbEmail = "c@gmail.com",
                    TtbPhone = "0923456789",
                    TtbAddress = "Đà Nẵng",
                    TtbAvatar = "avatar3.jpg",
                    TtbBirthday = new DateTime(1999, 12, 20),
                    TtbGender = "Nam",
                    TtbPassword = "pass123",
                    TtbFacebook = "https://facebook.com/levanc"
                },
                new TtbAccount
                {
                    TtbId = 4,
                    TtbFullName = "Phạm Thị D",
                    TtbEmail = "d@gmail.com",
                    TtbPhone = "0934567890",
                    TtbAddress = "Cần Thơ",
                    TtbAvatar = "avatar4.jpg",
                    TtbBirthday = new DateTime(2002, 3, 10),
                    TtbGender = "Nữ",
                    TtbPassword = "123abc",
                    TtbFacebook = "https://facebook.com/phamthid"
                },
                new TtbAccount
                {
                    TtbId = 5,
                    TtbFullName = "Đặng Văn E",
                    TtbEmail = "e@gmail.com",
                    TtbPhone = "0945678901",
                    TtbAddress = "Huế",
                    TtbAvatar = "avatar5.jpg",
                    TtbBirthday = new DateTime(1998, 7, 25),
                    TtbGender = "Nam",
                    TtbPassword = "mypassword",
                    TtbFacebook = "https://facebook.com/dangvane"
                }
            };

            return View(accounts);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult TtbCreate()
        {
            TtbAccount model = new TtbAccount();
            return View(model);
        }

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

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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

        public IActionResult VerifyPhone(string TtbPhone)
        {
           
            Regex _isPhone = new Regex(@"^0\d{9}$|^0\d{2}[-. ]\d{3}[-. ]\d{4}$");

            if (!_isPhone.IsMatch(TtbPhone))
            {
                return Json($"Số điện thoại {TtbPhone} không đúng định dạng, VD: 0978381287 hoặc 097.838.1287");
            }

            return Json(true);
        }
    }
}
