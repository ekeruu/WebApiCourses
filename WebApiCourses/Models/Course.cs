using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
    }
}
