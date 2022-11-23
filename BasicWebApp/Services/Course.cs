using System.ComponentModel.DataAnnotations.Schema;

namespace BasicWebApp.Services;
[Table("Course")]
public class Course
{
    [Column("CourseId")]
    public string Id { get; set; }

    public string CourseName { get; set; }

    public decimal Fees { get; set; }

    public int Duration { get; set; }

    public ICollection<Student> Students { get; set; } 
}