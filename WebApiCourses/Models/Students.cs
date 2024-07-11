using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Students
    {
        [Key]
        public int StudentsID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
