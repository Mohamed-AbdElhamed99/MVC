using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.ViewModels;
using System.Drawing;
using System.Security.Policy;

namespace MVC.Repositories
{
    public class InstructoreRepository : IInstructoreRepository
    {
        MVCContext _context;
        public InstructoreRepository(MVCContext Context) { 
            _context = Context;
        }

        public List<Instructore> GetAll()
        {
            return _context.Instructore
                .Skip(1)
                .Take(10)
                .Include("Department")
                .Include("Course")
                .ToList();
        }

        public List<Instructore> GetAll(int page = 1, int size = 10, string search = "")
        {
            return _context.Instructore
                .Skip((page - 1) * size)
                .Take(size)
                .Include("Department")
                .Include("Course")
                .Where(i => i.Name.ToLower().Contains(search.ToLower()) || i.Department.Name.ToLower().Contains(search.ToLower()) || i.Course.Name.ToLower().Contains(search.ToLower()))
                .ToList();
        }

        public Instructore GetById(int id)
        {
            return _context.Instructore
                .Include("Department")
                .Include("Course")
                .FirstOrDefault(d => d.Id == id);
        }

        public void Create(Instructore entity)
        {
            _context.Instructore.Add(entity);
        }

        public void Delete(int id)
        {
            Instructore Instructore = GetById(id);
            _context.Instructore.Remove(Instructore);
        } 

        public void Update(Instructore entity)
        {
            _context.Instructore.Update(entity);
        }

        public int Count(string search = "")
        {
            return _context.Instructore
                .Where(i => i.Name.ToLower().Contains(search.ToLower()) || i.Department.Name.ToLower().Contains(search.ToLower()) || i.Course.Name.ToLower().Contains(search.ToLower()))
                .Count();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
