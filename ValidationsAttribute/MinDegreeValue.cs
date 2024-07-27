using MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC.ValidationsAttribute;

public class MinDegreeValue : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        int minDegree;

        if(int.TryParse(value.ToString() , out minDegree))
        {
            Course course =  (Course)validationContext.ObjectInstance;

            if(minDegree <= course.Degree)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"This Course Minimum Degree Should be less than Degree");

            }
        }
        else
        {
            return new ValidationResult($"Minimum Degree Should be number");

        }
    }
}
