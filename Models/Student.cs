using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
