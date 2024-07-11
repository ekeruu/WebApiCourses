﻿using System.ComponentModel.DataAnnotations;

namespace WebApiCourses.Models
{
    public class Specialty
    {
        [Key]
        public int SpecialtyID { get; set; }
        public string SpecialtyName { get; set; }
    }
}
