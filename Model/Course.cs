using System.ComponentModel.DataAnnotations;


namespace StudyPal.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
    }
}
