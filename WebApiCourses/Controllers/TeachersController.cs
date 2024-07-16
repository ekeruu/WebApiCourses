using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiCourses.Models;
using WebApiCourses.Data;
using WebApiCourses.Models;

namespace YourNamespace.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public TeachersController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Teachers
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetTeachers()
        {
            return _context.Teacher.ToList();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> GetTeacher(int id)
        {
            var teacher = _context.Teacher.Find(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // PUT: api/Teachers/5
        [HttpPut("{id}")]
        public IActionResult PutTeacher(int id, Teacher teacher)
        {
            if (id != teacher.TeacherID)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Teachers
        [HttpPost]
        public ActionResult<Teacher> PostTeachers(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Teacher.Add(teacher);
            _context.SaveChanges();

            return CreatedAtAction("GetTeachers", new { id = teacher.TeacherID }, teacher);
        }

        // DELETE: api/Teachers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _context.Teacher.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teacher.Remove(teacher);
            _context.SaveChanges();

            return NoContent();
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.TeacherID == id);
        }
    }
}
