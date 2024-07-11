using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCourses.Models;

namespace WebApiCourses.Data
{
    public class WebApiCoursesContext : DbContext
    {
        public WebApiCoursesContext(DbContextOptions<WebApiCoursesContext> options) : base(options) { }

        public DbSet<Students> Students { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
        }
    }
}
