using Microsoft.AspNetCore.Mvc;
using TtbLesson07.Models;

namespace TtbLesson07.Controllers
{
    public class TtbEmployeeController : Controller
    {
        private static List<TtbEmployee> ttbListEmployees = new List<TtbEmployee>
        {
            new TtbEmployee { TtbId = 23109012, TtbName = "Tran The Binh", TtbBirthDay = new DateTime(2005,5, 25), TtbEmail = "binhtranthe@gmail.com", TtbPhone = "0978381287", TtbSalary = 12000000, TtbStatus = true },
            new TtbEmployee { TtbId = 2, TtbName = "Trần Thị B", TtbBirthDay = new DateTime(1992, 5, 15), TtbEmail = "b@example.com", TtbPhone = "0912233445", TtbSalary = 15000000, TtbStatus = true },
            new TtbEmployee { TtbId = 3, TtbName = "Lê Văn C", TtbBirthDay = new DateTime(1988, 9, 20), TtbEmail = "c@example.com", TtbPhone = "0922123456", TtbSalary = 11000000, TtbStatus = false },
            new TtbEmployee { TtbId = 4, TtbName = "Phạm Thị D", TtbBirthDay = new DateTime(1995, 3, 10), TtbEmail = "d@example.com", TtbPhone = "0933445566", TtbSalary = 13000000, TtbStatus = true },
            new TtbEmployee { TtbId = 5, TtbName = "Đỗ Văn E", TtbBirthDay = new DateTime(1991, 7, 25), TtbEmail = "e@example.com", TtbPhone = "0944567890", TtbSalary = 10000000, TtbStatus = false }
        };

        public IActionResult TtbIndex()
        {
            return View(ttbListEmployees);
        }

        public IActionResult TtbCreate()
        {
            var model = new TtbEmployee();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TtbCreate(TtbEmployee model)
        {
            try
            {
                if (model.TtbId == 0)
                {
                    model.TtbId = ttbListEmployees.Max(e => e.TtbId) + 1;
                }
                ttbListEmployees.Add(model);
                return RedirectToAction(nameof(TtbIndex));
            }
            catch
            {
                return View();
            }
        }

       [HttpGet]
public IActionResult TtbEdit(int id)
{
    var model = ttbListEmployees.FirstOrDefault(x => x.TtbId == id);
    return View(model);
}

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult TtbEdit(TtbEmployee model)
{
    var employee = ttbListEmployees.FirstOrDefault(e => e.TtbId == model.TtbId);
    if (employee != null)
    {
        employee.TtbName = model.TtbName;
        employee.TtbBirthDay = model.TtbBirthDay;
        employee.TtbEmail = model.TtbEmail;
        employee.TtbPhone = model.TtbPhone;
        employee.TtbSalary = model.TtbSalary;
        employee.TtbStatus = model.TtbStatus;
    }
    return RedirectToAction(nameof(TtbIndex));
}


        public IActionResult TtbDelete(int id)
        {
            var model = ttbListEmployees.FirstOrDefault(e => e.TtbId == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model); // view xác nhận xóa
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TtbDeleteConfirmed(int id)
        {
            var employee = ttbListEmployees.FirstOrDefault(e => e.TtbId == id);
            if (employee != null)
            {
                ttbListEmployees.Remove(employee);
            }
            return RedirectToAction(nameof(TtbIndex));
        }


        
    }
}
