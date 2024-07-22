using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class Solveissueintraineecourserelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Courses_CourseId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_CourseId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Trainees");

            migrationBuilder.CreateTable(
                name: "CourseTrainee",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TraineesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainee", x => new { x.CourseId, x.TraineesId });
                    table.ForeignKey(
                        name: "FK_CourseTrainee_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseTrainee_Trainees_TraineesId",
                        column: x => x.TraineesId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainee_TraineesId",
                table: "CourseTrainee",
                column: "TraineesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Trainees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 24,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 25,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 26,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 27,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 28,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 29,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 30,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 31,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 32,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 33,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 34,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 35,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 36,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 37,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 38,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 39,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 40,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 41,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 42,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 43,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 44,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 45,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 46,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 47,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 48,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 49,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 50,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 51,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 52,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 53,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 54,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 55,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 56,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 57,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 58,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 59,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 60,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 61,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 62,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 63,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 64,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 65,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 66,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 67,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 68,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 69,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 70,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 71,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 72,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 73,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 74,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 75,
                column: "CourseId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_CourseId",
                table: "Trainees",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Courses_CourseId",
                table: "Trainees",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
