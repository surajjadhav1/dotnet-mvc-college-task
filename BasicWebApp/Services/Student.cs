using System.ComponentModel.DataAnnotations.Schema;
namespace BasicWebApp.Services;

[Table("Student")]
public class Student
{
  
  public string CourseId { get; set; }

  [ Column("RollNo")]
  public int Id { get; set; }

  public string StudentName { get; set; }

  public int Age { get; set; }

  public string Grade { get; set; }
}