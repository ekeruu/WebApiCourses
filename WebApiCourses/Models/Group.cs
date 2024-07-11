using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public int SpecialtyID { get; set; }
        public int DepartmentID { get; set; }
    }
}
