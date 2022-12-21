using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class SchoolLevel_AddListStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolLevels_Students_StudentID",
                table: "SchoolLevels");

            migrationBuilder.DropIndex(
                name: "IX_SchoolLevels_StudentID",
                table: "SchoolLevels");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "SchoolLevels");

            migrationBuilder.CreateTable(
                name: "SchoolLevelStudent",
                columns: table => new
                {
                    SchoolLevelsSchoolLevelID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLevelStudent", x => new { x.SchoolLevelsSchoolLevelID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_SchoolLevelStudent_SchoolLevels_SchoolLevelsSchoolLevelID",
                        column: x => x.SchoolLevelsSchoolLevelID,
                        principalTable: "SchoolLevels",
                        principalColumn: "SchoolLevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolLevelStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLevelStudent_StudentsStudentID",
                table: "SchoolLevelStudent",
                column: "StudentsStudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolLevelStudent");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "SchoolLevels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLevels_StudentID",
                table: "SchoolLevels",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolLevels_Students_StudentID",
                table: "SchoolLevels",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID");
        }
    }
}
