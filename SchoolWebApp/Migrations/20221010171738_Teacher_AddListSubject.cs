using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class Teacher_AddListSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolLevelStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolLevelID",
                table: "Students",
                column: "SchoolLevelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SchoolLevels_SchoolLevelID",
                table: "Students",
                column: "SchoolLevelID",
                principalTable: "SchoolLevels",
                principalColumn: "SchoolLevelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_SchoolLevels_SchoolLevelID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolLevelID",
                table: "Students");

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
    }
}
