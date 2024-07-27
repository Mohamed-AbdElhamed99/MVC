using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;
using System.Collections;
using System.Drawing.Printing;

namespace MVC.Controllers
{
    public class InstructoreController : Controller
    {
        IDepartmentRepository departmentRepository;
        IInstructoreRepository instructoreRepository;
        ICourseRepository courseRepository;
        IWebHostEnvironment _webHostEnvironment;

        public InstructoreController(ICourseRepository _courseRepository , IInstructoreRepository _instructoreRepository , IDepartmentRepository _departmentRepository, IWebHostEnvironment webHostEnvironment)
        {
            instructoreRepository = _instructoreRepository;
            departmentRepository = _departmentRepository;
            courseRepository = _courseRepository;
           _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index(int page = 1 , int size = 10 , string search = "")
        {
            List<Instructore> l = instructoreRepository.GetAll(page , size , search);

            List<ListInstructoresViewModel>? instructores =
                l.Select(x => new ListInstructoresViewModel {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = $"/images/{x.Image}",
                    Salary = x.Salary,
                    DepartmentName = x.Department?.Name,
                    CourseName = x.Course?.Name })
                .ToList();

            int itemsCount = instructoreRepository.Count();
            ViewBag.Pagination = PaginationController.setPagination(itemsCount , page , size) ;
       
            return View("Index" , instructores);
        }


        public IActionResult Details(int id)
        {
            Instructore instructore = instructoreRepository.GetById(id);
            ShowInstructoreDetailsViewModel? viewModel = new ShowInstructoreDetailsViewModel {
                Id = instructore.Id,
                Name = instructore.Name,
                ImageUrl = $"/images/{instructore.Image}",
                Salary = instructore.Salary,
                Address = instructore?.Address,
                DepartmentName = instructore.Department?.Name,
                CourseName = instructore.Course?.Name
            };
            return View("Details", viewModel);
        }

        public IActionResult Create()
        {
            CreateInstructoreViewModel model = new CreateInstructoreViewModel();
            model.Departments = departmentRepository.GetAll();
            return View("Create", model);
        }

        public IActionResult Store(CreateInstructoreViewModel newInstructore)
        {
            if (ModelState.IsValid)
            {
                if (newInstructore.FormFile != null)
                {
                    string file_name = $"{Guid.NewGuid().ToString()}_{newInstructore.FormFile.FileName}";
                    string folder = $"/images/{file_name}";
                    string path = this._webHostEnvironment.WebRootPath.Replace("\\", "/") + folder;
                    newInstructore.FormFile.CopyToAsync(new FileStream(path, FileMode.Create));
                    newInstructore.Image = file_name;
                }
                instructoreRepository.Create((Instructore)newInstructore);
                instructoreRepository.Save();

                return RedirectToAction("Index");
            }
            else
            {
                newInstructore.Departments = departmentRepository.GetAll();
                return View("Create", newInstructore);
            }

        }

        public IActionResult Edit(int Id)
        {
            CreateInstructoreViewModel model = new CreateInstructoreViewModel();

            Instructore instructore = instructoreRepository.GetById(Id);

            model.Id = instructore.Id;
            model.Name = instructore.Name;
            model.Salary = instructore.Salary;
            model.Image = instructore.Image;
            model.Address = instructore.Address;
            model.CourseId = instructore.CourseId;
            model.DepartmentId = instructore.DepartmentId;

            model.Departments = departmentRepository.GetAll();
            model.Courses = courseRepository.GetCoursesByDeptId(instructore.DepartmentId);

            return View("Edit", model);
        }

        public IActionResult Update(int Id, Instructore instructore)
        {
            instructoreRepository.Update(instructore);
            instructoreRepository.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            instructoreRepository.Delete(Id);
            instructoreRepository.Save();
            return RedirectToAction("Index");
        }

        public IActionResult GetCourses(int deptID)
        {
            return Json(courseRepository.GetCoursesByDeptId(deptID));
        }
    }
}
