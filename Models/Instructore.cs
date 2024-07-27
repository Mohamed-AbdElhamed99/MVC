using MVC.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models;

public class Instructore
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    public int Salary{ get; set; }
    public string? Address { get; set; }
    [ForeignKey("Course")]
    public int? CourseId { get; set; }
    [ForeignKey("Department")]
    public int? DepartmentId { get; set; }
    public virtual Course? Course { get; set; }
    public virtual Department? Department { get; set; }

    public static implicit operator Instructore(CreateInstructoreViewModel vm)
    {
        return new Instructore { 
            Id = vm.Id,
            Name = vm.Name,
            Image = vm.Image,
            Salary = vm.Salary,
            Address = vm.Address,
            DepartmentId = vm.DepartmentId,
            CourseId = vm.CourseId,  
        };
    }
}
