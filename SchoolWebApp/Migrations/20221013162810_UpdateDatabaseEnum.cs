using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class UpdateDatabaseEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "TeacherID1",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 2,
                column: "PolishValue",
                value: "Dopuszczajacy");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 5,
                column: "PolishValue",
                value: "Bardzo dobry");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID1",
                table: "Subjects",
                column: "TeacherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID1",
                table: "Subjects",
                column: "TeacherID1",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID1",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID1",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeacherID1",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 2,
                column: "PolishValue",
                value: "Dopuszczający");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 5,
                column: "PolishValue",
                value: "Bardzo Dobry");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
