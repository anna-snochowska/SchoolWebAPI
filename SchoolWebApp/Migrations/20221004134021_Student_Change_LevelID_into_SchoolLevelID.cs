using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class Student_Change_LevelID_into_SchoolLevelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LevelID",
                table: "Students",
                newName: "SchoolLevelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SchoolLevelID",
                table: "Students",
                newName: "LevelID");
        }
    }
}
