using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCourses.Data;
using WebApiCourses.Models;

namespace WebApiCourses.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public StudentsController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }


        // PUT: Students/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Students student)
        {
            if (id != student.StudentsID)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;
        
                await _context.SaveChangesAsync();
            
            return NoContent();
        }


        // POST: Students
        // POST: Students
        [HttpPost]
        public async Task<ActionResult<Students>> PostStudent(Students student)
        {
            
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Students.Add(student);
                await _context.SaveChangesAsync();

                // После сохранения студента вызываем GetStudent для получения актуальных данных (включая StudentsID)
                return CreatedAtAction(nameof(GetStudent), new { id = student.StudentsID }, student);
            
           
        }



        // DELETE: Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
           
                var student = await _context.Students.FindAsync(id);
                if (student == null)
                {
                    return NotFound();
                }

                _context.Students.Remove(student);
                await _context.SaveChangesAsync();

                return NoContent();
           
        }

    }
}
