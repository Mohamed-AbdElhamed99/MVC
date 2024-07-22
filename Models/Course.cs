using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models;

public class Course
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Degree { get; set; }
    public int MinDegree { get; set; }
    public int Hours { get; set; }
    [ForeignKey("Department")]
    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual List<Instructore>? Instructores { get; set; }

    public virtual List<Trainee>? Trainees { get; set; }
}
