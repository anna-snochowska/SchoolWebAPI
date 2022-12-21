namespace SchoolWebApp.Models
{
    public class SchoolLevel
    {
        public int SchoolLevelID { get; set; }
        [Required]
        public string TypeOfSchool { get; set; } = string.Empty;
        public string LevelValue { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
