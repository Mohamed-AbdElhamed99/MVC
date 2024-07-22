namespace MVC.ViewModels;

public class CourseResultViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TrainerDegree { get; set; }
    public int FullDegree { get; set; }
    public int MinDegree { get; set; }
    public int Hours { get; set; }
    public string SuccessStatus {
        get
        {
            if (TrainerDegree >= MinDegree ) return "Success";
            else return "Fail";
        } 
     }

    public string Color
    {
        get
        {
            if (TrainerDegree >= MinDegree) return "table-success";
            else return "table-danger";
        }
    }
}
