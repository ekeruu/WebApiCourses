using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApiCourses.Models;
using WebApiCourses.Data;
using WebApiCourses.Models;

namespace WebApiCourses.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public CoursesController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_context.Course.ToList());
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _context.Course.Find(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // POST: api/Courses
        [HttpPost]
        public IActionResult PostCourse(Course course)
        {
            _context.Course.Add(course);
            _context.SaveChanges();

            return CreatedAtAction("GetCourse", new { id = course.CourseID }, course);
        }

        // PUT: api/Courses/5
        [HttpPut("{id}")]
        public IActionResult PutCourse(int id, Course course)
        {
            if (id != course.CourseID)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            var course = _context.Course.Find(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
