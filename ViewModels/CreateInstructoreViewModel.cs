using MVC.Models;
using MVC.ValidationsAttribute;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using static MVC.ValidationsAttribute.NotAllowedZero;

namespace MVC.ViewModels;

public class CreateInstructoreViewModel
{
    public int Id { get; set; }

    [DisplayName("Name")]
    public string Name { get; set; }

    public string? Image { get; set; }

    [Display(Name = "Salary Amount")]
    [Range(5000, 100000 , ErrorMessage = "Salary range between 5000 and 100000")]
    public int Salary { get; set; }

    public string? Address { get; set; }

    [Display(Name = "Course")]
    [NotAllowedZero(ErrorMessage = "Please Select Course")]
    public int? CourseId { get; set; }

    [Display(Name = "Department")]
    [NotAllowedZero(ErrorMessage = "Please Select Department")]
    public int? DepartmentId { get; set; }

    [Required(ErrorMessage = "Image is required")]
    public IFormFile FormFile{ get; set; }

    public List<Department>? Departments { get; set; }

    public List<Course>? Courses { get; set; }
}
