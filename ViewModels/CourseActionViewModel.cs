using MVC.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.ViewModels;

public class CourseActionViewModel
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public int? Degree { get; set; }
    public int? MinDegree { get; set; }
    public int? Hours { get; set; }
    public int? DepartmentId { get; set; }
    public List<Department>? Department { get; set; }
}
