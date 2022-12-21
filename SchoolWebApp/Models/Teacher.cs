namespace SchoolWebApp.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        [Required]
        public string TeacherName { get; set; } = string.Empty;
        public string TeacherSurname { get; set; } = string.Empty;
        public int ExperienceInYears { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
