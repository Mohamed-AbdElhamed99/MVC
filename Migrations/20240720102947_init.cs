using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoursesResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    TraineeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    MinDegree = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Instructore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructore_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Instructore_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CoursesResult",
                columns: new[] { "Id", "CourseId", "Degree", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 88, 1 },
                    { 2, 1, 75, 2 },
                    { 3, 1, 90, 3 },
                    { 4, 1, 85, 4 },
                    { 5, 1, 92, 5 },
                    { 6, 2, 80, 6 },
                    { 7, 2, 87, 7 },
                    { 8, 2, 79, 8 },
                    { 9, 2, 84, 9 },
                    { 10, 2, 91, 10 },
                    { 11, 3, 83, 11 },
                    { 12, 3, 88, 12 },
                    { 13, 3, 82, 13 },
                    { 14, 3, 86, 14 },
                    { 15, 3, 90, 15 },
                    { 16, 4, 88, 16 },
                    { 17, 4, 75, 17 },
                    { 18, 4, 90, 18 },
                    { 19, 4, 85, 19 },
                    { 20, 4, 92, 20 },
                    { 21, 5, 80, 21 },
                    { 22, 5, 87, 22 },
                    { 23, 5, 79, 23 },
                    { 24, 5, 84, 24 },
                    { 25, 5, 91, 25 },
                    { 26, 6, 83, 26 },
                    { 27, 6, 88, 27 },
                    { 28, 6, 82, 28 },
                    { 29, 6, 86, 29 },
                    { 30, 6, 90, 30 },
                    { 31, 7, 88, 31 },
                    { 32, 7, 75, 32 },
                    { 33, 7, 90, 33 },
                    { 34, 7, 85, 34 },
                    { 35, 7, 92, 35 },
                    { 36, 8, 80, 36 },
                    { 37, 8, 87, 37 },
                    { 38, 8, 79, 38 },
                    { 39, 8, 84, 39 },
                    { 40, 8, 91, 40 },
                    { 41, 9, 83, 41 },
                    { 42, 9, 88, 42 },
                    { 43, 9, 82, 43 },
                    { 44, 9, 86, 44 },
                    { 45, 9, 90, 45 },
                    { 46, 10, 88, 46 },
                    { 47, 10, 75, 47 },
                    { 48, 10, 90, 48 },
                    { 49, 10, 85, 49 },
                    { 50, 10, 92, 50 },
                    { 51, 11, 80, 51 },
                    { 52, 11, 87, 52 },
                    { 53, 11, 79, 53 },
                    { 54, 11, 84, 54 },
                    { 55, 11, 91, 55 },
                    { 56, 12, 83, 56 },
                    { 57, 12, 88, 57 },
                    { 58, 12, 82, 58 },
                    { 59, 12, 86, 59 },
                    { 60, 12, 90, 60 },
                    { 61, 13, 88, 61 },
                    { 62, 13, 75, 62 },
                    { 63, 13, 90, 63 },
                    { 64, 13, 85, 64 },
                    { 65, 13, 92, 65 },
                    { 66, 14, 80, 66 },
                    { 67, 14, 87, 67 },
                    { 68, 14, 79, 68 },
                    { 69, 14, 84, 69 },
                    { 70, 14, 91, 70 },
                    { 71, 15, 83, 71 },
                    { 72, 15, 88, 72 },
                    { 73, 15, 82, 73 },
                    { 74, 15, 86, 74 },
                    { 75, 15, 90, 75 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Mohamed", "SD" },
                    { 2, "Sara", "HR" },
                    { 3, "John", "Finance" },
                    { 4, "Linda", "Marketing" },
                    { 5, "Alex", "IT" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DepartmentId", "Hours", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100, 1, 100, 55, ".NET" },
                    { 2, 90, 1, 80, 50, "C#" },
                    { 3, 95, 1, 90, 53, "ASP.NET Core" },
                    { 4, 85, 2, 70, 50, "Human Resources Management" },
                    { 5, 88, 2, 75, 52, "Recruitment Strategies" },
                    { 6, 90, 2, 80, 55, "Employee Relations" },
                    { 7, 92, 3, 85, 54, "Financial Accounting" },
                    { 8, 95, 3, 90, 55, "Corporate Finance" },
                    { 9, 90, 3, 80, 52, "Investment Management" },
                    { 10, 93, 4, 85, 55, "Digital Marketing" },
                    { 11, 88, 4, 75, 50, "Marketing Research" },
                    { 12, 91, 4, 80, 53, "Consumer Behavior" },
                    { 13, 95, 5, 90, 55, "Networking" },
                    { 14, 92, 5, 85, 54, "Cybersecurity" },
                    { 15, 90, 5, 80, 52, "Database Management" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Address", "CourseId", "DepartmentId", "Grade", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Cairo", null, 1, "Grade 1", "avatar.png", "Mohamed" },
                    { 2, "Giza", null, 1, "Grade 2", "avatar.png", "Ahmed" },
                    { 3, "Alexandria", null, 1, "Grade 3", "avatar.png", "Sara" },
                    { 4, "Luxor", null, 1, "Grade 1", "avatar.png", "Omar" },
                    { 5, "Aswan", null, 1, "Grade 2", "avatar.png", "Amina" },
                    { 6, "Suez", null, 1, "Grade 3", "avatar.png", "Hassan" },
                    { 7, "Cairo", null, 1, "Grade 1", "avatar.png", "Reem" },
                    { 8, "Giza", null, 1, "Grade 2", "avatar.png", "Nour" },
                    { 9, "Alexandria", null, 1, "Grade 3", "avatar.png", "Ali" },
                    { 10, "Luxor", null, 1, "Grade 1", "avatar.png", "Zainab" },
                    { 11, "Aswan", null, 1, "Grade 2", "avatar.png", "Tamer" },
                    { 12, "Suez", null, 1, "Grade 3", "avatar.png", "Laila" },
                    { 13, "Cairo", null, 1, "Grade 1", "avatar.png", "Mahmoud" },
                    { 14, "Giza", null, 1, "Grade 2", "avatar.png", "Samir" },
                    { 15, "Alexandria", null, 1, "Grade 3", "avatar.png", "Heba" },
                    { 16, "Cairo", null, 2, "Grade 1", "avatar.png", "Youssef" },
                    { 17, "Giza", null, 2, "Grade 2", "avatar.png", "Dina" },
                    { 18, "Alexandria", null, 2, "Grade 3", "avatar.png", "Rania" },
                    { 19, "Luxor", null, 2, "Grade 1", "avatar.png", "Hussein" },
                    { 20, "Aswan", null, 2, "Grade 2", "avatar.png", "Fady" },
                    { 21, "Suez", null, 2, "Grade 3", "avatar.png", "Mariam" },
                    { 22, "Cairo", null, 2, "Grade 1", "avatar.png", "Ola" },
                    { 23, "Giza", null, 2, "Grade 2", "avatar.png", "Karim" },
                    { 24, "Alexandria", null, 2, "Grade 3", "avatar.png", "Farah" },
                    { 25, "Luxor", null, 2, "Grade 1", "avatar.png", "Basma" },
                    { 26, "Aswan", null, 2, "Grade 2", "avatar.png", "Fahd" },
                    { 27, "Suez", null, 2, "Grade 3", "avatar.png", "Nadine" },
                    { 28, "Cairo", null, 2, "Grade 1", "avatar.png", "Hala" },
                    { 29, "Giza", null, 2, "Grade 2", "avatar.png", "Salma" },
                    { 30, "Alexandria", null, 2, "Grade 3", "avatar.png", "Hadi" },
                    { 31, "Cairo", null, 3, "Grade 1", "avatar.png", "Lina" },
                    { 32, "Giza", null, 3, "Grade 2", "avatar.png", "Marwa" },
                    { 33, "Alexandria", null, 3, "Grade 3", "avatar.png", "Hani" },
                    { 34, "Luxor", null, 3, "Grade 1", "avatar.png", "Kareem" },
                    { 35, "Aswan", null, 3, "Grade 2", "avatar.png", "Shereen" },
                    { 36, "Suez", null, 3, "Grade 3", "avatar.png", "Ziad" },
                    { 37, "Cairo", null, 3, "Grade 1", "avatar.png", "Nada" },
                    { 38, "Giza", null, 3, "Grade 2", "avatar.png", "Tarek" },
                    { 39, "Alexandria", null, 3, "Grade 3", "avatar.png", "Mai" },
                    { 40, "Luxor", null, 3, "Grade 1", "avatar.png", "Rami" },
                    { 41, "Aswan", null, 3, "Grade 2", "avatar.png", "Hadeer" },
                    { 42, "Suez", null, 3, "Grade 3", "avatar.png", "Fadi" },
                    { 43, "Cairo", null, 3, "Grade 1", "avatar.png", "Sherif" },
                    { 44, "Giza", null, 3, "Grade 2", "avatar.png", "Lamis" },
                    { 45, "Alexandria", null, 3, "Grade 3", "avatar.png", "Amr" },
                    { 46, "Cairo", null, 4, "Grade 1", "avatar.png", "Yasmin" },
                    { 47, "Giza", null, 4, "Grade 2", "avatar.png", "Ayman" },
                    { 48, "Alexandria", null, 4, "Grade 3", "avatar.png", "Nahla" },
                    { 49, "Luxor", null, 4, "Grade 1", "avatar.png", "Dalia" },
                    { 50, "Aswan", null, 4, "Grade 2", "avatar.png", "Sami" },
                    { 51, "Suez", null, 4, "Grade 3", "avatar.png", "Maha" },
                    { 52, "Cairo", null, 4, "Grade 1", "avatar.png", "Lila" },
                    { 53, "Giza", null, 4, "Grade 2", "avatar.png", "Nader" },
                    { 54, "Alexandria", null, 4, "Grade 3", "avatar.png", "Rana" },
                    { 55, "Luxor", null, 4, "Grade 1", "avatar.png", "Adel" },
                    { 56, "Aswan", null, 4, "Grade 2", "avatar.png", "Farida" },
                    { 57, "Suez", null, 4, "Grade 3", "avatar.png", "Tala" },
                    { 58, "Cairo", null, 4, "Grade 1", "avatar.png", "Lamis" },
                    { 59, "Giza", null, 4, "Grade 2", "avatar.png", "Jamal" },
                    { 60, "Alexandria", null, 4, "Grade 3", "avatar.png", "Malak" },
                    { 61, "Cairo", null, 5, "Grade 1", "avatar.png", "Rasha" },
                    { 62, "Giza", null, 5, "Grade 2", "avatar.png", "Salem" },
                    { 63, "Alexandria", null, 5, "Grade 3", "avatar.png", "Ibrahim" },
                    { 64, "Luxor", null, 5, "Grade 1", "avatar.png", "Zaki" },
                    { 65, "Aswan", null, 5, "Grade 2", "avatar.png", "Ghada" },
                    { 66, "Suez", null, 5, "Grade 3", "avatar.png", "Ismail" },
                    { 67, "Cairo", null, 5, "Grade 1", "avatar.png", "Nadia" },
                    { 68, "Giza", null, 5, "Grade 2", "avatar.png", "Samir" },
                    { 69, "Alexandria", null, 5, "Grade 3", "avatar.png", "Hala" },
                    { 70, "Luxor", null, 5, "Grade 1", "avatar.png", "Kamal" },
                    { 71, "Aswan", null, 5, "Grade 2", "avatar.png", "Yara" },
                    { 72, "Suez", null, 5, "Grade 3", "avatar.png", "Omar" },
                    { 73, "Cairo", null, 5, "Grade 1", "avatar.png", "Bassem" },
                    { 74, "Giza", null, 5, "Grade 2", "avatar.png", "Nourhan" },
                    { 75, "Alexandria", null, 5, "Grade 3", "avatar.png", "Tarek" }
                });

            migrationBuilder.InsertData(
                table: "Instructore",
                columns: new[] { "Id", "Address", "CourseId", "DepartmentId", "Image", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo", 1, 1, "avatar.png", "Mohamed", 2500 },
                    { 2, "Giza", 1, 1, "avatar.png", "Ahmed", 2600 },
                    { 3, "Alexandria", 2, 1, "avatar.png", "Amina", 2700 },
                    { 4, "Luxor", 2, 1, "avatar.png", "Omar", 2800 },
                    { 5, "Aswan", 3, 1, "avatar.png", "Sara", 2900 },
                    { 6, "Suez", 3, 1, "avatar.png", "Mona", 3000 },
                    { 7, "Cairo", 4, 2, "avatar.png", "Hassan", 3100 },
                    { 8, "Giza", 4, 2, "avatar.png", "Reem", 3200 },
                    { 9, "Alexandria", 5, 2, "avatar.png", "Nour", 3300 },
                    { 10, "Luxor", 5, 2, "avatar.png", "Layla", 3400 },
                    { 11, "Aswan", 6, 2, "avatar.png", "Khaled", 3500 },
                    { 12, "Suez", 6, 2, "avatar.png", "Fatma", 3600 },
                    { 13, "Cairo", 7, 3, "avatar.png", "Ali", 3700 },
                    { 14, "Giza", 7, 3, "avatar.png", "Zainab", 3800 },
                    { 15, "Alexandria", 8, 3, "avatar.png", "Tamer", 3900 },
                    { 16, "Luxor", 8, 3, "avatar.png", "Hoda", 4000 },
                    { 17, "Aswan", 9, 3, "avatar.png", "Mahmoud", 4100 },
                    { 18, "Suez", 9, 3, "avatar.png", "Laila", 4200 },
                    { 19, "Cairo", 10, 4, "avatar.png", "Samir", 4300 },
                    { 20, "Giza", 10, 4, "avatar.png", "Heba", 4400 },
                    { 21, "Alexandria", 11, 4, "avatar.png", "Youssef", 4500 },
                    { 22, "Luxor", 11, 4, "avatar.png", "Dina", 4600 },
                    { 23, "Aswan", 12, 4, "avatar.png", "Rania", 4700 },
                    { 24, "Suez", 12, 4, "avatar.png", "Hussein", 4800 },
                    { 25, "Cairo", 13, 5, "avatar.png", "Fady", 4900 },
                    { 26, "Giza", 13, 5, "avatar.png", "Mariam", 5000 },
                    { 27, "Alexandria", 14, 5, "avatar.png", "Ola", 5100 },
                    { 28, "Luxor", 14, 5, "avatar.png", "Karim", 5200 },
                    { 29, "Aswan", 15, 5, "avatar.png", "Farah", 5300 },
                    { 30, "Suez", 15, 5, "avatar.png", "Basma", 5400 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructore_CourseId",
                table: "Instructore",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructore_DepartmentId",
                table: "Instructore",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_CourseId",
                table: "Trainees",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_DepartmentId",
                table: "Trainees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesResult");

            migrationBuilder.DropTable(
                name: "Instructore");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
