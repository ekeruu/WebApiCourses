namespace WebApiCourses.Models
{
    public class CourseSchedule
    {
        public int CourseScheduleID { get; set; }
        public int CourseID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int Hours { get; set; }
    }
}
