using MVC.Models;

namespace MVC.Repositories
{
    public interface IInstructoreRepository : IRepository<Instructore>
    {
        List<Instructore> GetAll(int page = 1, int size = 10, string search = "");
        int Count(string search = "");
    }
}
