using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Enrollment
{
    [Key]
    public int EnrollmentId { get; set; }

    [Required]
    public string CourseName { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public int StudentId { get; set; }

    [ForeignKey("StudentId")]
    public virtual Student Student { get; set; }
}
