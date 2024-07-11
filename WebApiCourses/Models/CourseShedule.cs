using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class CourseShedule
    {
        [Key]
        public int CourseSheduleID { get; set; }
        public int CourseID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int Hours { get; set; }
    }
}
