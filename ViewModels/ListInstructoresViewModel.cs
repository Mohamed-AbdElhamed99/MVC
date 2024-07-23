namespace MVC.ViewModels;

public class ListInstructoresViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary {  get; set; }
    public string ImageUrl { get; set; }
    public string DepartmentName { get; set; }
    public string CourseName { get; set; }
    public PaginationViewModel Pagination { get; set; }
}
