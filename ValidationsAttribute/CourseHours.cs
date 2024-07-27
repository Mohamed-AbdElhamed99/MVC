using System.ComponentModel.DataAnnotations;

namespace MVC.ValidationsAttribute;

public class CourseHours : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        int hours;

        if(int.TryParse(value.ToString() , out hours))
        {
            if (hours % 3 == 0)
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
}
