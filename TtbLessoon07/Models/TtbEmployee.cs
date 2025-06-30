namespace TtbLesson07.Models
{
    public class TtbEmployee
    {
        public int TtbId { get; set; }              // Mã nhân viên
        public string TtbName { get; set; }         // Họ tên
        public DateTime TtbBirthDay { get; set; }   // Ngày sinh
        public string TtbEmail { get; set; }        // Email
        public string TtbPhone { get; set; }        // Số điện thoại
        public decimal TtbSalary { get; set; }      // Lương
        public bool TtbStatus { get; set; }         // Trạng thái (true = đang làm việc, false = nghỉ việc)
    }
}
