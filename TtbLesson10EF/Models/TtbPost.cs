using System;
using System.Collections.Generic;

namespace TtbLesson10EF.Models;

public partial class TtbPost
{
    public int Ttbid { get; set; }

    public string? TtbTitle { get; set; }

    public string? TtbImages { get; set; }

    public string? TtbContent { get; set; }

    public bool? TtbStatus { get; set; }
}
