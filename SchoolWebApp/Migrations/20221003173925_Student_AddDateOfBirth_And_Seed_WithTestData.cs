using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApp.Migrations
{
    public partial class Student_AddDateOfBirth_And_Seed_WithTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "MarkID", "AmericanValue", "PolishValue" },
                values: new object[,]
                {
                    { 1, "F", "Niedostateczny" },
                    { 2, "E", "Dopuszczający" },
                    { 3, "D", "Dostateczny" },
                    { 4, "C", "Dobry" },
                    { 5, "B", "Bardzo Dobry" },
                    { 6, "A", "Celujacy" }
                });

            migrationBuilder.InsertData(
                table: "SchoolLevels",
                columns: new[] { "SchoolLevelID", "LevelValue", "TypeOfSchool" },
                values: new object[,]
                {
                    { 1, "First", "PrimerySchool" },
                    { 2, "Second", "PrimerySchool" },
                    { 3, "Third", "PrimerySchool" },
                    { 4, "Fourth", "PrimerySchool" },
                    { 5, "Fifth", "PrimerySchool" },
                    { 6, "Sixth", "PrimerySchool" },
                    { 7, "First", "MiddleSchool" },
                    { 8, "Second", "MiddleSchool" },
                    { 9, "Third", "MiddleSchool" },
                    { 10, "First", "HighSchool" },
                    { 11, "Second", "HighSchool" },
                    { 12, "Third", "HighSchool" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "LevelID", "StudentName", "StudentSurname" },
                values: new object[,]
                {
                    { 1, new DateTime(1991, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Anna", "Snochowska" },
                    { 2, new DateTime(1988, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Jacek", "Abramczyk" },
                    { 3, new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Agnieszka", "Jankowska" },
                    { 4, new DateTime(1991, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Patryk", "Baj" },
                    { 5, new DateTime(1991, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Rosselina", "Drożyńska" },
                    { 6, new DateTime(1983, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Łukasz", "Kalinowski" },
                    { 7, new DateTime(1982, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Anna", "Kalinowska" },
                    { 8, new DateTime(1985, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Karol", "Kiełbiński" },
                    { 9, new DateTime(1995, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Anna", "Krzyżanowska" },
                    { 10, new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Beata", "Turczuk" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectID", "ClassroomNumber", "HoursPerWeek", "SubjectName", "TeacherID" },
                values: new object[,]
                {
                    { 1, "1A", 5, "Math", 1 },
                    { 2, "2A", 3, "Polish", 2 },
                    { 3, "2B", 4, "English", 3 },
                    { 4, "2C", 2, "History", 2 },
                    { 5, "3A", 2, "Geografy", 7 },
                    { 6, "4A", 1, "Art", 5 },
                    { 7, "Gym", 4, "PE", 4 },
                    { 8, "1B", 2, "Physics", 1 },
                    { 9, "3B", 3, "Chemistry", 6 },
                    { 10, "3C", 1, "Biology", 6 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "ExperienceInYears", "TeacherName", "TeacherSurname" },
                values: new object[,]
                {
                    { 1, 5, "Jolanta", "Matmiewska" },
                    { 2, 4, "Paweł", "Polski" },
                    { 3, 9, "Alicja", "Angielski" },
                    { 4, 2, "Jan", "Silka" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "ExperienceInYears", "TeacherName", "TeacherSurname" },
                values: new object[] { 5, 1, "Mateusz", "Sztukowski" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "ExperienceInYears", "TeacherName", "TeacherSurname" },
                values: new object[] { 6, 5, "Wojciech", "Bioloski" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "ExperienceInYears", "TeacherName", "TeacherSurname" },
                values: new object[] { 7, 7, "Anna", "Mapa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "SchoolLevelID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Students");
        }
    }
}
