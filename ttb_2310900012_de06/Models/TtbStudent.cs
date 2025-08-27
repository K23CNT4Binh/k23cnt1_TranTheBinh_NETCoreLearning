using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ttb_2310900012_de06.Models
{
    [Table("TtbStudent")] // 👈 Rất quan trọng
    public class TtbStudent
    {
        [Key]
        public int TtbStudId { get; set; }
        public string? TtbStudName { get; set; }
        public int TtbStudAge { get; set; }
        public string? TtbStudGender { get; set; }
        public string? TtbEmail { get; set; }
        public bool TtbStudStatus { get; set; }
    }
}
