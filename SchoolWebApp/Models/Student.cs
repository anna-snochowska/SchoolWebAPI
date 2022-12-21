namespace SchoolWebApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; } = string.Empty;
        public string StudentSurname { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int SchoolLevelID { get; set; }
    }
}
