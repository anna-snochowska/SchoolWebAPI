using Microsoft.EntityFrameworkCore;

namespace SchoolWebApp.Data
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext(DbContextOptions<SchoolDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolLevel>().Navigation(s => s.Students).AutoInclude();

            modelBuilder.Entity<Teacher>().Navigation(t => t.Subjects).AutoInclude();

            modelBuilder.Entity<Student>().HasData(

                new Student { StudentID = 1, StudentName = "Anna", StudentSurname = "Snochowska", DateOfBirth = new DateTime(1991, 09, 19), SchoolLevelID = 10 },
                new Student { StudentID = 2, StudentName = "Jacek", StudentSurname = "Abramczyk", DateOfBirth = new DateTime(1988, 05, 10), SchoolLevelID = 5 },
                new Student { StudentID = 3, StudentName = "Agnieszka", StudentSurname = "Jankowska", DateOfBirth = new DateTime(1991, 02, 26), SchoolLevelID = 12 },
                new Student { StudentID = 4, StudentName = "Patryk", StudentSurname = "Baj", DateOfBirth = new DateTime(1991, 06, 12), SchoolLevelID = 2 },
                new Student { StudentID = 5, StudentName = "Rosselina", StudentSurname = "Drożyńska", DateOfBirth = new DateTime(1991, 03, 05), SchoolLevelID = 2 },
                new Student { StudentID = 6, StudentName = "Łukasz", StudentSurname = "Kalinowski", DateOfBirth = new DateTime(1983, 12, 17), SchoolLevelID = 9 },
                new Student { StudentID = 7, StudentName = "Anna", StudentSurname = "Kalinowska", DateOfBirth = new DateTime(1982, 02, 12), SchoolLevelID = 7 },
                new Student { StudentID = 8, StudentName = "Karol", StudentSurname = "Kiełbiński", DateOfBirth = new DateTime(1985, 04, 06), SchoolLevelID = 11 },
                new Student { StudentID = 9, StudentName = "Anna", StudentSurname = "Krzyżanowska", DateOfBirth = new DateTime(1995, 06, 23), SchoolLevelID = 1 },
                new Student { StudentID = 10, StudentName = "Beata", StudentSurname = "Turczuk", DateOfBirth = new DateTime(1993, 05, 27), SchoolLevelID = 1 });

            modelBuilder.Entity<SchoolLevel>().HasData(

               new SchoolLevel { SchoolLevelID = 1, TypeOfSchool = "PrimerySchool", LevelValue = "First" },
               new SchoolLevel { SchoolLevelID = 2, TypeOfSchool = "PrimerySchool", LevelValue = "Second" },
               new SchoolLevel { SchoolLevelID = 3, TypeOfSchool = "PrimerySchool", LevelValue = "Third" },
               new SchoolLevel { SchoolLevelID = 4, TypeOfSchool = "PrimerySchool", LevelValue = "Fourth" },
               new SchoolLevel { SchoolLevelID = 5, TypeOfSchool = "PrimerySchool", LevelValue = "Fifth" },
               new SchoolLevel { SchoolLevelID = 6, TypeOfSchool = "PrimerySchool", LevelValue = "Sixth" },
               new SchoolLevel { SchoolLevelID = 7, TypeOfSchool = "MiddleSchool", LevelValue = "First" },
               new SchoolLevel { SchoolLevelID = 8, TypeOfSchool = "MiddleSchool", LevelValue = "Second" },
               new SchoolLevel { SchoolLevelID = 9, TypeOfSchool = "MiddleSchool", LevelValue = "Third" },
               new SchoolLevel { SchoolLevelID = 10, TypeOfSchool = "HighSchool", LevelValue = "First" },
               new SchoolLevel { SchoolLevelID = 11, TypeOfSchool = "HighSchool", LevelValue = "Second" },
               new SchoolLevel { SchoolLevelID = 12, TypeOfSchool = "HighSchool", LevelValue = "Third" });

            modelBuilder.Entity<Subject>().HasData(

               new Subject { SubjectID = 1, TeacherID = TeacherEnum.Matmiewska, SubjectName = "Math", HoursPerWeek = 5, ClassroomNumber = "1A" },
               new Subject { SubjectID = 2, TeacherID = TeacherEnum.Polski, SubjectName = "Polish", HoursPerWeek = 3, ClassroomNumber = "2A" },
               new Subject { SubjectID = 3, TeacherID = TeacherEnum.Angielski, SubjectName = "English", HoursPerWeek = 4, ClassroomNumber = "2B" },
               new Subject { SubjectID = 4, TeacherID = TeacherEnum.Polski, SubjectName = "History", HoursPerWeek = 2, ClassroomNumber = "2C" },
               new Subject { SubjectID = 5, TeacherID = TeacherEnum.Mapa, SubjectName = "Geografy", HoursPerWeek = 2, ClassroomNumber = "3A" },
               new Subject { SubjectID = 6, TeacherID = TeacherEnum.Sztukowski, SubjectName = "Art", HoursPerWeek = 1, ClassroomNumber = "4A" },
               new Subject { SubjectID = 7, TeacherID = TeacherEnum.Silka, SubjectName = "PE", HoursPerWeek = 4, ClassroomNumber = "Gym" },
               new Subject { SubjectID = 8, TeacherID = TeacherEnum.Matmiewska, SubjectName = "Physics", HoursPerWeek = 2, ClassroomNumber = "1B" },
               new Subject { SubjectID = 9, TeacherID = TeacherEnum.Bioloski, SubjectName = "Chemistry", HoursPerWeek = 3, ClassroomNumber = "3B" },
               new Subject { SubjectID = 10, TeacherID = TeacherEnum.Bioloski, SubjectName = "Biology", HoursPerWeek = 1, ClassroomNumber = "3C" });

            modelBuilder.Entity<Teacher>().HasData(

               new Teacher { TeacherID = 1, TeacherName = "Jolanta", TeacherSurname = "Matmiewska", ExperienceInYears = 5 },
               new Teacher { TeacherID = 2, TeacherName = "Paweł", TeacherSurname = "Polski", ExperienceInYears = 4 },
               new Teacher { TeacherID = 3, TeacherName = "Alicja", TeacherSurname = "Angielski", ExperienceInYears = 9 },
               new Teacher { TeacherID = 4, TeacherName = "Jan", TeacherSurname = "Silka", ExperienceInYears = 2 },
               new Teacher { TeacherID = 5, TeacherName = "Mateusz", TeacherSurname = "Sztukowski", ExperienceInYears = 1 },
               new Teacher { TeacherID = 6, TeacherName = "Wojciech", TeacherSurname = "Bioloski", ExperienceInYears = 5 },
               new Teacher { TeacherID = 7, TeacherName = "Anna", TeacherSurname = "Mapa", ExperienceInYears = 7 });

            modelBuilder.Entity<Mark>().HasData(

                new Mark { MarkID = 1, PolishValue = "Niedostateczny", AmericanValue = "F" },
                new Mark { MarkID = 2, PolishValue = "Dopuszczajacy", AmericanValue = "E" },
                new Mark { MarkID = 3, PolishValue = "Dostateczny", AmericanValue = "D" },
                new Mark { MarkID = 4, PolishValue = "Dobry", AmericanValue = "C" },
                new Mark { MarkID = 5, PolishValue = "Bardzo dobry", AmericanValue = "B" },
                new Mark { MarkID = 6, PolishValue = "Celujacy", AmericanValue = "A" });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<SchoolLevel> SchoolLevels { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}

