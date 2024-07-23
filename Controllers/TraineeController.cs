using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.ViewModels;
using System.Drawing;

namespace MVC.Controllers
{
    public class TraineeController : Controller
    {
        MVCContext _context = new MVCContext();
        // GET: TraineeController
        public ActionResult Index(int page = 1 , int size = 10)
        {
            List<ListTraineeViewModel> trainee = _context.Trainees
                .Skip((page - 1) * size)
                .Take(size)
                .Select(x => new ListTraineeViewModel() { Id = x.Id , Name = x.Name , Address = x.Address , DepartmentName = x.Department.Name , Grade = x.Grade , ImageUrl = $"/images/{x.Image}" })
                .ToList();

            int itemsCount = _context.Trainees.ToList().Count();
            ViewBag.Pagination = PaginationController.setPagination(itemsCount, page, size);

            return View("index" , trainee);
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int Id)
        {
            TraineeDetailsViewModel? viewModel = new TraineeDetailsViewModel();

            Trainee? trainee = _context.Trainees
                .Where(x => x.Id == Id)
                .Include(d => d.Department)
                .Include(cr => cr.CourseResult)
                .ThenInclude(cr => cr.Course)
                .FirstOrDefault();

            if(trainee != null)
            {
                viewModel.Id = trainee.Id;
                viewModel.Name = trainee.Name;
                viewModel.Address = trainee.Address;
                viewModel.DepartmentName = trainee.Department?.Name;
                viewModel.Grade = trainee.Grade;
                viewModel.ImageUrl = $"images/{trainee.Image}";

                viewModel.Courses = new List<CourseResultViewModel>();
                foreach (var item in trainee.CourseResult)
                {
                    var vm = new CourseResultViewModel()
                    {
                        Id = item.Course.Id,
                        Name = item.Course.Name,
                        TrainerDegree = item.Degree,
                        Hours = item.Course.Hours,
                        FullDegree = item.Course.Degree,
                        MinDegree = item.Course.MinDegree
                    };
                    viewModel.Courses.Add(vm);
                }
            }
            return View("Details" , viewModel);
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TraineeController/Edit/5
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

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TraineeController/Delete/5
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
}
