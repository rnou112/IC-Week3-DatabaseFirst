using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class EnglishStudent
{
    public int StudenId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? Email { get; set; }
}
