using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public int ExperienceYears { get; set; }
    }
}
