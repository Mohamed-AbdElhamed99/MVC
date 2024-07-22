using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class addcourseresultlisttocourseandtraineemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListTraineeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTraineeViewModel", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 31,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 32,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 33,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 36,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 37,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 38,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 39,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 40,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 41,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 42,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 43,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 44,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 45,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 46,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 47,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 48,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 49,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 51,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 53,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 54,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 55,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 56,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 57,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 58,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 59,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 60,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 62,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 63,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 64,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 65,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 67,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 68,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 69,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 72,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 73,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 74,
                column: "Image",
                value: "avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 75,
                column: "Image",
                value: "avatar.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListTraineeViewModel");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Instructore",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 31,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 32,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 33,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 36,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 37,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 38,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 39,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 40,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 41,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 42,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 43,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 44,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 45,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 46,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 47,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 48,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 49,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 51,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 53,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 54,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 55,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 56,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 57,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 58,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 59,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 60,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 62,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 63,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 64,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 65,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 67,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 68,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 69,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 72,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 73,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 74,
                column: "Image",
                value: "avatar.png");

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 75,
                column: "Image",
                value: "avatar.png");
        }
    }
}
