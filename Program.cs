// See https://aka.ms/new-console-template for more information

using  DatabaseFirst.Models;

using (var context = new LmsContext())
{

   /* var courses = context.Courses.ToList();
    //Console.WriteLine("Course count=" + courses.Count);

    foreach(Course course in courses)
    {
        Console.WriteLine("Course Id= " + course.Id + " Course Name= " + course.Name + " Course Desc= " + course.Description);
    }
   */

    
    // var student = context.Students.FirstOrDefault(item => item.Id == 4);

    //Console.WriteLine("Student name before update: " + student.Name);

    /*
    // Validate student is not null
    if (student != null)
    {
        student.Name = "Kate New Name";
        student.Email = "kate2@email.com";
        context.SaveChanges();
    }

    var student2 = context.Students.FirstOrDefault(item => item.Id == 2);
    Console.WriteLine("Student name after update: " + student2.Name);

    */

    var students = context.Students.Where(item => item.Id == 4 || item.Id == 2);

    context.Students.RemoveRange(students);

    context.SaveChanges();
}

Console.ReadLine();