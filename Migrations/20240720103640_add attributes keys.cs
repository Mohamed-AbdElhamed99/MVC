using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class addattributeskeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CoursesResult_CourseId",
                table: "CoursesResult",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesResult_TraineeId",
                table: "CoursesResult",
                column: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Courses_CourseId",
                table: "CoursesResult",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Trainees_TraineeId",
                table: "CoursesResult",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Courses_CourseId",
                table: "CoursesResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Trainees_TraineeId",
                table: "CoursesResult");

            migrationBuilder.DropIndex(
                name: "IX_CoursesResult_CourseId",
                table: "CoursesResult");

            migrationBuilder.DropIndex(
                name: "IX_CoursesResult_TraineeId",
                table: "CoursesResult");
        }
    }
}
