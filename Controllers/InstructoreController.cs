using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;
using System.Drawing.Printing;

namespace MVC.Controllers
{
    public class InstructoreController : Controller
    {
        MVCContext _context =  new MVCContext();
        

        public IActionResult Index(int page = 1 , int size = 10 , string search = "")
        {
            List<ListInstructoresViewModel> instructors = _context.Instructore
                .Skip((page - 1) * size)
                .Take(size)
                .Where(i => i.Name.ToLower().Contains(search.ToLower()) || i.Department.Name.ToLower().Contains(search.ToLower()) || i.Course.Name.ToLower().Contains(search.ToLower()))
                .Select(x => new ListInstructoresViewModel { Id=x.Id , Name=x.Name, ImageUrl=$"/images/{x.Image}", Salary=x.Salary,DepartmentName=x.Department.Name , CourseName = x.Course.Name})
                .ToList();


            int itemsCount = _context.Instructore.ToList().Count();
            ViewBag.Pagination = PaginationController.setPagination(itemsCount , page , size) ;
       
            return View("Index" , instructors);
        }


        public IActionResult Details(int id) {
            ShowInstructoreDetailsViewModel instructor = _context.Instructore
                .Where(x => x.Id == id)
                .Select(x => new ShowInstructoreDetailsViewModel { Id = x.Id, Name = x.Name, ImageUrl = $"/images/{x.Image}", Address=x.Address ,Salary = x.Salary, DepartmentName = x.Department.Name, CourseName = x.Course.Name })
                .FirstOrDefault();

          return View("Details" , instructor);
        }

        public IActionResult Create()
        {
            CreateInstructorViewModel model = new CreateInstructorViewModel();

            model.Courses = _context.Courses.ToList();
            model.Departments = _context.Departments.ToList();

            return View("Create" , model);
        }

        public IActionResult Store(Instructore newInstructore)
        {
            if(newInstructore.Name != null && newInstructore.Salary != null && newInstructore.Image != null && newInstructore.Salary > 0)
            {
                _context.Instructore.Add(newInstructore);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create" , newInstructore);
        }

        public IActionResult Edit(int Id)
        {
            CreateInstructorViewModel model = new CreateInstructorViewModel();

            model.Courses = _context.Courses.ToList();
            model.Departments = _context.Departments.ToList();

            Instructore instructore = _context.Instructore.Where(x => x.Id == Id).FirstOrDefault();

            model.Id = instructore.Id;
            model.Name = instructore.Name;
            model.Salary = instructore.Salary;
            model.Image = instructore.Image;
            model.Address = instructore.Address;
            model.CourseId = instructore.CourseId;
            model.DepartmentId = instructore.DepartmentId;

            return View("Edit", model);
        }

        public IActionResult Update(int Id ,Instructore updatedInstructore)
        {
            if (updatedInstructore.Name != null && updatedInstructore.Salary != null && updatedInstructore.Image != null && updatedInstructore.Salary > 0)
            {
                Instructore instructore = _context.Instructore.Where(x => x.Id == Id).FirstOrDefault();

                instructore.Id = updatedInstructore.Id ;
                instructore.Name = updatedInstructore.Name ;
                instructore.Salary = updatedInstructore.Salary ;
                instructore.Image = updatedInstructore.Image ;
                instructore.Address = updatedInstructore.Address ;
                instructore.CourseId = updatedInstructore.CourseId ;
                instructore.DepartmentId = updatedInstructore.DepartmentId;


                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            CreateInstructorViewModel model = new CreateInstructorViewModel();

            model.Courses = _context.Courses.ToList();
            model.Departments = _context.Departments.ToList();
            model.Id = updatedInstructore.Id;
            model.Name = updatedInstructore.Name;
            model.Salary = updatedInstructore.Salary;
            model.Image = updatedInstructore.Image;
            model.Address = updatedInstructore.Address;
            model.CourseId = updatedInstructore.CourseId;
            model.DepartmentId = updatedInstructore.DepartmentId;
            return View("Edit", updatedInstructore);
        }

        public IActionResult Delete(int Id)
        {
            Instructore instructore = _context.Instructore.Where(x => x.Id == Id).FirstOrDefault();
            _context.Instructore.Remove(instructore);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
