using System;
using System.ComponentModel.DataAnnotations;

namespace TranTheBinh_2310900012.Models
{
    public class TtbEmployee
    {
        [Key] // 👉 Thêm dòng này
        public int TtbEmpId { get; set; }

        public string TtbEmpName { get; set; }
        public string TtbEmpLevel { get; set; }
        public DateTime TtbEmpStartDate { get; set; }
        public bool TtbEmpStatus { get; set; }
    }
}
