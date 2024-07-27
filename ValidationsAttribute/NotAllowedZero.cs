using System.ComponentModel.DataAnnotations;

namespace MVC.ValidationsAttribute
{
    public class NotAllowedZero : ValidationAttribute
    {

            public override bool IsValid(object? value)
            {
                int val = int.Parse(value.ToString());
                if (val > 0)
                    return true;
                return false;
            }

    }
}
