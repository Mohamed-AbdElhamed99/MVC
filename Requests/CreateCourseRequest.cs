using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ValidationsAttribute;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Requests;

public class CreateCourseRequest
{
   // [Required]
    [MaxLength(20)]
    [MinLength(2)]
    [UniqueCourseName]
    public string Name { get; set; }    

    
    [Remote("ValidateDegree", "Course", ErrorMessage = "Course Degree must be between 50 and 100")]
    public int Degree { get; set; }

    [Remote("ValidateMinDegree", "Course",AdditionalFields = "Degree" ,ErrorMessage = "Course Minimum Degree must be Less than Degree")]
    public int MinDegree { get; set; }

    [Remote("ValidateHours", "Course", ErrorMessage = "The number of hours must be divisible by 3")]
    public int Hours { get; set; }

    [Display(Name = "Department")]
    [NotAllowedZero(ErrorMessage = "Please Select Department")]
    public int? DepartmentId { get; set; }

    public List<Department>? departments { get; set; }
}
