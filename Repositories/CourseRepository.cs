using MVC.Models;

namespace MVC.Repositories;

public class CourseRepository : ICourseRepository
{
    MVCContext _context;
    public CourseRepository(MVCContext Context)
    {
        _context = Context;
    }

    public List<Course> GetAll()
    {
        return _context.Courses.ToList();
    }

    public List<Course> GetCoursesByDeptId(int? deptId)
    {
        return _context.Courses.Where(x => x.DepartmentId == deptId).ToList();
    }
  
    public Course GetById(int id)
    {
        return _context.Courses.FirstOrDefault(d => d.Id == id);
    }

    public void Create(Course entity)
    {
        _context.Courses.Add(entity);
    }

    public void Delete(int id)
    {
        Course course = GetById(id);
        _context.Courses.Remove(course);
    }

    public void Update(Course entity)
    {
        _context.Courses.Update(entity);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
