using MVC.Models;

namespace MVC.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        MVCContext _context;
        public DepartmentRepository(MVCContext Context)
        {
            _context = Context;
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Create(Department entity)
        {
            _context.Departments.Add(entity);
        }

        public void Delete(int id)
        {
            Department department = GetById(id);
            _context.Departments.Remove(department);
        }

        public void Update(Department entity)
        {
            _context.Departments.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
