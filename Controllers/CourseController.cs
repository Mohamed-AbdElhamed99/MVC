using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.ViewModels;
using System.Drawing;

namespace MVC.Controllers;

public class CourseController : Controller
{
    MVCContext _context = new MVCContext();
    // GET: CourseController
    public ActionResult Index(int page = 1, int size = 10, string search = "")
    {
        List<ListCoursesViewModel> courses = _context.Courses
           .Skip((page - 1) * size)
           .Take(size)
           .Where(i => i.Name.ToLower().Contains(search.ToLower()) || i.Department.Name.ToLower().Contains(search.ToLower()) )
           .Select(x => new ListCoursesViewModel { Id = x.Id, Name = x.Name, DeptName = x.Department.Name,Hours = x.Hours , Degree = x.Degree , MinDegree = x.MinDegree })
           .ToList();


        int itemsCount = _context.Courses.ToList().Count();
        ViewBag.Pagination = PaginationController.setPagination(itemsCount, page, size);

        return View("Index", courses);
    }


    // GET: CourseController/Create
    public ActionResult Create()
    {
        CourseActionViewModel courseActionView = new CourseActionViewModel();

        courseActionView.Department = _context.Departments.ToList();

        return View("Create" , courseActionView);
    }

    // POST: CourseController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Course newCourse)
    {
        _context.Courses.Add(newCourse);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // GET: CourseController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: CourseController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: CourseController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: CourseController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
