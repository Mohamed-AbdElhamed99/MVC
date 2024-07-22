namespace MVC.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manager { get; set; }

    public List<Instructore>? Instructores { get; set;}
    public List<Course>? Courses { get; set;}
    public List<Trainee>? Trainees { get; set;}
}
