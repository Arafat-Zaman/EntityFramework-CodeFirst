using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}
