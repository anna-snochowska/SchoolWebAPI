using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class Student_AddAutoInclude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
