namespace SchoolWebApp.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public TeacherEnum TeacherID { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int HoursPerWeek { get; set; }
        public string ClassroomNumber { get; set; } = string.Empty;
    }

    public enum TeacherEnum
    {
        Matmiewska = 1,
        Polski = 2,
        Angielski = 3,
        Silka = 4,
        Sztukowski = 5,
        Bioloski = 6,
        Mapa = 7,

    }
}
