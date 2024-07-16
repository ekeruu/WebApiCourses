using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Specialty
    {
        [Key]
        public int SpecialtyID { get; set; }
        [Required]
        public string SpecialtyName { get; set; }
    }
}
