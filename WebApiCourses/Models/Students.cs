using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Students
    {
        [Key]
        public int StudentsID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        [Required]

        public string Patronymic { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public int GroupID { get; set; }
    }
}
