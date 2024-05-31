using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Course
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
