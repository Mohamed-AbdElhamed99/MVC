using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using MVC.ViewModels;

namespace MVC.Models;

public class MVCContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructore> Instructore { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<CourseResult> CoursesResult { get; set;}

    public MVCContext()
    {

    }

    public MVCContext(DbContextOptions<MVCContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = MOHAMED\\MOHAMEDSQLSERVER; Database = MVC; Trusted_Connection = True; Encrypt = False");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Departments
        modelBuilder.Entity<Department>().HasData(
            new Department() { Id = 1, Name = "SD", Manager = "Mohamed" },
            new Department() { Id = 2, Name = "HR", Manager = "Sara" },
            new Department() { Id = 3, Name = "Finance", Manager = "John" },
            new Department() { Id = 4, Name = "Marketing", Manager = "Linda" },
            new Department() { Id = 5, Name = "IT", Manager = "Alex" }
        );
        #endregion
        #region Courses
        modelBuilder.Entity<Course>().HasData(
            // Courses for Department 1 (SD)
            new Course() { Id = 1, Name = ".NET", Degree = 100, MinDegree = 55, Hours = 100, DepartmentId = 1 },
            new Course() { Id = 2, Name = "C#", Degree = 90, MinDegree = 50, Hours = 80, DepartmentId = 1 },
            new Course() { Id = 3, Name = "ASP.NET Core", Degree = 95, MinDegree = 53, Hours = 90, DepartmentId = 1 },

            // Courses for Department 2 (HR)
            new Course() { Id = 4, Name = "Human Resources Management", Degree = 85, MinDegree = 50, Hours = 70, DepartmentId = 2 },
            new Course() { Id = 5, Name = "Recruitment Strategies", Degree = 88, MinDegree = 52, Hours = 75, DepartmentId = 2 },
            new Course() { Id = 6, Name = "Employee Relations", Degree = 90, MinDegree = 55, Hours = 80, DepartmentId = 2 },

            // Courses for Department 3 (Finance)
            new Course() { Id = 7, Name = "Financial Accounting", Degree = 92, MinDegree = 54, Hours = 85, DepartmentId = 3 },
            new Course() { Id = 8, Name = "Corporate Finance", Degree = 95, MinDegree = 55, Hours = 90, DepartmentId = 3 },
            new Course() { Id = 9, Name = "Investment Management", Degree = 90, MinDegree = 52, Hours = 80, DepartmentId = 3 },

            // Courses for Department 4 (Marketing)
            new Course() { Id = 10, Name = "Digital Marketing", Degree = 93, MinDegree = 55, Hours = 85, DepartmentId = 4 },
            new Course() { Id = 11, Name = "Marketing Research", Degree = 88, MinDegree = 50, Hours = 75, DepartmentId = 4 },
            new Course() { Id = 12, Name = "Consumer Behavior", Degree = 91, MinDegree = 53, Hours = 80, DepartmentId = 4 },

            // Courses for Department 5 (IT)
            new Course() { Id = 13, Name = "Networking", Degree = 95, MinDegree = 55, Hours = 90, DepartmentId = 5 },
            new Course() { Id = 14, Name = "Cybersecurity", Degree = 92, MinDegree = 54, Hours = 85, DepartmentId = 5 },
            new Course() { Id = 15, Name = "Database Management", Degree = 90, MinDegree = 52, Hours = 80, DepartmentId = 5 }
        );
        #endregion
        #region Instructores
        modelBuilder.Entity<Instructore>().HasData(
          // Instructors for Department 1 (SD)
          new Instructore() { Id = 1, Name = "Mohamed", Salary = 2500, Address = "Cairo", Image = "avatar.jpg", DepartmentId = 1, CourseId = 1 },
          new Instructore() { Id = 2, Name = "Ahmed", Salary = 2600, Address = "Giza", Image = "avatar.jpg", DepartmentId = 1, CourseId = 1 },
          new Instructore() { Id = 3, Name = "Amina", Salary = 2700, Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 1, CourseId = 2 },
          new Instructore() { Id = 4, Name = "Omar", Salary = 2800, Address = "Luxor", Image = "avatar.jpg", DepartmentId = 1, CourseId = 2 },
          new Instructore() { Id = 5, Name = "Sara", Salary = 2900, Address = "Aswan", Image = "avatar.jpg", DepartmentId = 1, CourseId = 3 },
          new Instructore() { Id = 6, Name = "Mona", Salary = 3000, Address = "Suez", Image = "avatar.jpg", DepartmentId = 1, CourseId = 3 },

          // Instructores for Department 2 (HR)
          new Instructore() { Id = 7, Name = "Hassan", Salary = 3100, Address = "Cairo", Image = "avatar.jpg", DepartmentId = 2, CourseId = 4 },
          new Instructore() { Id = 8, Name = "Reem", Salary = 3200, Address = "Giza", Image = "avatar.jpg", DepartmentId = 2, CourseId = 4 },
          new Instructore() { Id = 9, Name = "Nour", Salary = 3300, Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 2, CourseId = 5 },
          new Instructore() { Id = 10, Name = "Layla", Salary = 3400, Address = "Luxor", Image = "avatar.jpg", DepartmentId = 2, CourseId = 5 },
          new Instructore() { Id = 11, Name = "Khaled", Salary = 3500, Address = "Aswan", Image = "avatar.jpg", DepartmentId = 2, CourseId = 6 },
          new Instructore() { Id = 12, Name = "Fatma", Salary = 3600, Address = "Suez", Image = "avatar.jpg", DepartmentId = 2, CourseId = 6 },

          // Instructores for Department 3 (Finance)
          new Instructore() { Id = 13, Name = "Ali", Salary = 3700, Address = "Cairo", Image = "avatar.jpg", DepartmentId = 3, CourseId = 7 },
          new Instructore() { Id = 14, Name = "Zainab", Salary = 3800, Address = "Giza", Image = "avatar.jpg", DepartmentId = 3, CourseId = 7 },
          new Instructore() { Id = 15, Name = "Tamer", Salary = 3900, Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 3, CourseId = 8 },
          new Instructore() { Id = 16, Name = "Hoda", Salary = 4000, Address = "Luxor", Image = "avatar.jpg", DepartmentId = 3, CourseId = 8 },
          new Instructore() { Id = 17, Name = "Mahmoud", Salary = 4100, Address = "Aswan", Image = "avatar.jpg", DepartmentId = 3, CourseId = 9 },
          new Instructore() { Id = 18, Name = "Laila", Salary = 4200, Address = "Suez", Image = "avatar.jpg", DepartmentId = 3, CourseId = 9 },

          // Instructores for Department 4 (Marketing)
          new Instructore() { Id = 19, Name = "Samir", Salary = 4300, Address = "Cairo", Image = "avatar.jpg", DepartmentId = 4, CourseId = 10 },
          new Instructore() { Id = 20, Name = "Heba", Salary = 4400, Address = "Giza", Image = "avatar.jpg", DepartmentId = 4, CourseId = 10 },
          new Instructore() { Id = 21, Name = "Youssef", Salary = 4500, Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 4, CourseId = 11 },
          new Instructore() { Id = 22, Name = "Dina", Salary = 4600, Address = "Luxor", Image = "avatar.jpg", DepartmentId = 4, CourseId = 11 },
          new Instructore() { Id = 23, Name = "Rania", Salary = 4700, Address = "Aswan", Image = "avatar.jpg", DepartmentId = 4, CourseId = 12 },
          new Instructore() { Id = 24, Name = "Hussein", Salary = 4800, Address = "Suez", Image = "avatar.jpg", DepartmentId = 4, CourseId = 12 },

          // Instructores for Department 5 (IT)
          new Instructore() { Id = 25, Name = "Fady", Salary = 4900, Address = "Cairo", Image = "avatar.jpg", DepartmentId = 5, CourseId = 13 },
          new Instructore() { Id = 26, Name = "Mariam", Salary = 5000, Address = "Giza", Image = "avatar.jpg", DepartmentId = 5, CourseId = 13 },
          new Instructore() { Id = 27, Name = "Ola", Salary = 5100, Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 5, CourseId = 14 },
          new Instructore() { Id = 28, Name = "Karim", Salary = 5200, Address = "Luxor", Image = "avatar.jpg", DepartmentId = 5, CourseId = 14 },
          new Instructore() { Id = 29, Name = "Farah", Salary = 5300, Address = "Aswan", Image = "avatar.jpg", DepartmentId = 5, CourseId = 15 },
          new Instructore() { Id = 30, Name = "Basma", Salary = 5400, Address = "Suez", Image = "avatar.jpg", DepartmentId = 5, CourseId = 15 }
       );
        #endregion
        #region Trainee
        modelBuilder.Entity<Trainee>().HasData(
    // Trainees for Department 1 (SD)
    new Trainee() { Id = 1, Name = "Mohamed", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 2, Name = "Ahmed", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 3, Name = "Sara", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 4, Name = "Omar", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 5, Name = "Amina", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 6, Name = "Hassan", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 7, Name = "Reem", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 8, Name = "Nour", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 9, Name = "Ali", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 10, Name = "Zainab", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 11, Name = "Tamer", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 12, Name = "Laila", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 13, Name = "Mahmoud", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 14, Name = "Samir", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 1 },
    new Trainee() { Id = 15, Name = "Heba", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 1 },

    // Trainees for Department 2 (HR)
    new Trainee() { Id = 16, Name = "Youssef", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 17, Name = "Dina", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 18, Name = "Rania", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 19, Name = "Hussein", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 20, Name = "Fady", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 21, Name = "Mariam", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 22, Name = "Ola", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 23, Name = "Karim", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 24, Name = "Farah", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 25, Name = "Basma", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 26, Name = "Fahd", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 27, Name = "Nadine", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 28, Name = "Hala", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 29, Name = "Salma", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 2 },
    new Trainee() { Id = 30, Name = "Hadi", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 2 },

    // Trainees for Department 3 (Finance)
    new Trainee() { Id = 31, Name = "Lina", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 32, Name = "Marwa", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 33, Name = "Hani", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 34, Name = "Kareem", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 35, Name = "Shereen", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 36, Name = "Ziad", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 37, Name = "Nada", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 38, Name = "Tarek", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 39, Name = "Mai", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 40, Name = "Rami", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 41, Name = "Hadeer", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 42, Name = "Fadi", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 43, Name = "Sherif", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 44, Name = "Lamis", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 3 },
    new Trainee() { Id = 45, Name = "Amr", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 3 },

    // Trainees for Department 4 (Marketing)
    new Trainee() { Id = 46, Name = "Yasmin", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 47, Name = "Ayman", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 48, Name = "Nahla", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 49, Name = "Dalia", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 50, Name = "Sami", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 51, Name = "Maha", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 52, Name = "Lila", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 53, Name = "Nader", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 54, Name = "Rana", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 55, Name = "Adel", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 56, Name = "Farida", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 57, Name = "Tala", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 58, Name = "Lamis", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 59, Name = "Jamal", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 4 },
    new Trainee() { Id = 60, Name = "Malak", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 4 },

    // Trainees for Department 5 (IT)
    new Trainee() { Id = 61, Name = "Rasha", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 62, Name = "Salem", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 63, Name = "Ibrahim", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 64, Name = "Zaki", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 65, Name = "Ghada", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 66, Name = "Ismail", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 67, Name = "Nadia", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 68, Name = "Samir", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 69, Name = "Hala", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 70, Name = "Kamal", Grade = "Grade 1", Address = "Luxor", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 71, Name = "Yara", Grade = "Grade 2", Address = "Aswan", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 72, Name = "Omar", Grade = "Grade 3", Address = "Suez", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 73, Name = "Bassem", Grade = "Grade 1", Address = "Cairo", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 74, Name = "Nourhan", Grade = "Grade 2", Address = "Giza", Image = "avatar.jpg", DepartmentId = 5 },
    new Trainee() { Id = 75, Name = "Tarek", Grade = "Grade 3", Address = "Alexandria", Image = "avatar.jpg", DepartmentId = 5 }
);
        #endregion
        #region Course Results
        var random = new Random();

        var courseResults = new List<CourseResult>();
        int idCounter = 1;

        // Assuming you have 60 trainees (15 trainees per department * 4 departments)
        for (int traineeId = 1; traineeId <= 60; traineeId++)
        {
            var assignedCourses = new HashSet<int>();
            while (assignedCourses.Count < 5)
            {
                int randomCourseId = random.Next(1, 16);
                if (!assignedCourses.Contains(randomCourseId))
                {
                    assignedCourses.Add(randomCourseId);
                    courseResults.Add(new CourseResult()
                    {
                        Id = idCounter++,
                        CourseId = randomCourseId,
                        TraineeId = traineeId,
                        Degree = random.Next(1, 101)
                    });
                }
            }
        }

        modelBuilder.Entity<CourseResult>().HasData(courseResults.ToArray());

        #endregion
    }
    
}
