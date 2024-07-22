using MVC.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.ViewModels;

public class CreateInstructorViewModel
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public int? Salary { get; set; }
    public string? Address { get; set; }
    public int? CourseId { get; set; }
    public int? DepartmentId { get; set; }

    public List<Course>? Courses { get; set; }
    public List<Department>? Departments { get; set; }

}
