using Microsoft.AspNetCore.Mvc;
using TtbLab6.Models;

namespace TtbLab6.Controllers
{
    public class TtbEmployeeController : Controller
    {
        // Danh sách nhân viên giả lập
        private static List<TtbEmployee> ttbListEmployee = new List<TtbEmployee>
        {
            new TtbEmployee
            {
                TtbId = 1,
                TtbFullName = "Trần Thế Bình",
                TtbBirthDay = new DateTime(2005, 06, 27),
                TtbEmail = "binhtranthe@gmail.com",
                TtbPhone = "0978381287",
                TtbSalary = 12000000,
                TtbStatus = true
            },
            new TtbEmployee
            {
                TtbId = 2,
                TtbFullName = "Trần Thị B",
                TtbBirthDay = new DateTime(2000, 8, 20),
                TtbEmail = "b.tran@example.com",
                TtbPhone = "0909876543",
                TtbSalary = 10000000,
                TtbStatus = true
            },
            new TtbEmployee
            {
                TtbId = 3,
                TtbFullName = "Lê Văn C",
                TtbBirthDay = new DateTime(1998, 3, 15),
                TtbEmail = "c.le@example.com",
                TtbPhone = "0932123456",
                TtbSalary = 9500000,
                TtbStatus = false
            },
            new TtbEmployee
            {
                TtbId = 4,
                TtbFullName = "Phạm Thị D",
                TtbBirthDay = new DateTime(1997, 12, 5),
                TtbEmail = "d.pham@example.com",
                TtbPhone = "0922233444",
                TtbSalary = 10500000,
                TtbStatus = true
            },
            new TtbEmployee
            {
                TtbId = 5,
                TtbFullName = "Tên của bạn (SV)",
                TtbBirthDay = new DateTime(2003, 9, 1),
                TtbEmail = "sv.email@example.com",
                TtbPhone = "0987654321",
                TtbSalary = 15000000,
                TtbStatus = true
            }
        };

        // Hiển thị danh sách
        public IActionResult TtbList()
        {
            return View(ttbListEmployee);
        }

        // Form thêm mới (GET)
        [HttpGet]
        public IActionResult TtbCreate()
        {
            return View(); // ✅ Đúng: View() sẽ tự động tìm đến Views/TtbEmployee/TtbCreate.cshtml
        }


        // Xử lý thêm mới (POST)
        [HttpPost]
        public IActionResult TtbCreateSubmit(TtbEmployee emp)
        {
            emp.TtbId = ttbListEmployee.Count + 1;
            ttbListEmployee.Add(emp);
            return RedirectToAction("TtbEmployeeList"); // Sửa lại tên Action đúng
        }
    }
}
