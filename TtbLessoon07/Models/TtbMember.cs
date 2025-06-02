using System.ComponentModel.DataAnnotations;

namespace TtbLesson07.Models
{
    public class TtbMember
    {
        public int ttbId { get; set; }

        public string ttbName { get; set; }
        public string ttbUserName { get; set; }

        public string ttbPassword { get; set; }

        public string ttbEmail { get; set; }

        public bool ttbStatus { get; set; }
    }
}

