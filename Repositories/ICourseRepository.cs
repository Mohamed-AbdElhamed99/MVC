using MVC.Models;

namespace MVC.Repositories;

public interface ICourseRepository : IRepository<Course>
{
    List<Course> GetCoursesByDeptId(int? deptId);
}
