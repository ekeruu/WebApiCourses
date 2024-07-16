using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        [Required]

        public string Patronymic { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public int ExperienceYears { get; set; }
    }
}
