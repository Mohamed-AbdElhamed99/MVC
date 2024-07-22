using MVC.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.ViewModels;

public class ListTraineeViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string? Address { get; set; }
    public string Grade { get; set; }
    public string DepartmentName { get; set; }

}
