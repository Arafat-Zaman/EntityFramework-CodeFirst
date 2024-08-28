using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Ensure the database is created
        using (var context = new SchoolContext())
        {
            // Create
            var student = new Student
            {
                Name = "John Doe",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            context.Students.Add(student);
            context.SaveChanges();

            // Read
            var students = context.Students.ToList();
            foreach (var stu in students)
            {
                Console.WriteLine($"Student ID: {stu.StudentId}, Name: {stu.Name}");
            }

            // Update
            var studentToUpdate = context.Students.First();
            studentToUpdate.Name = "John Doe Updated";
            context.SaveChanges();

            // Delete
            var studentToDelete = context.Students.Last();
            context.Students.Remove(studentToDelete);
            context.SaveChanges();
        }
    }
}
