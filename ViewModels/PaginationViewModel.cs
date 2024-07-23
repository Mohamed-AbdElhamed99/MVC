namespace MVC.ViewModels;

public class PaginationViewModel
{
    public int NextPage { get; set; }
    public int PrevousePage { get; set; }
    public int CurrentPage { get; set; }
    public int NumberOfPages { get; set; }
    public int Size { get; set; }
    public List<int> Pages { get; set; }
}
