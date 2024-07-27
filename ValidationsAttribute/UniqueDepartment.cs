using MVC.Models;
using MVC.Requests;
using System.ComponentModel.DataAnnotations;

namespace MVC.ValidationsAttribute;

public class UniqueCourseName : ValidationAttribute
{

    MVCContext context = new MVCContext();
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult($"The Course Name is required");
        }

        string? name = value.ToString();

        CreateCourseRequest requets = (CreateCourseRequest)validationContext.ObjectInstance;
        Department department = context.Departments.FirstOrDefault(x => x.Id == requets.DepartmentId);


        Course course = context.Courses.FirstOrDefault(c => c.Name == name & c.Department.Id == department.Id);
    
        if(course == null)
        {
            return ValidationResult.Success;
        }else
        {
            return new ValidationResult($"This Course Name {name} Already Exists in Department {department.Name}");
        }
    }
}
