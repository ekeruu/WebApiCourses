using Microsoft.AspNetCore.Mvc;
using WebApiCourses.Data;
using WebApiCourses.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using WebApiCourses.Models;

namespace WebApiCourses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialtiesController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public SpecialtiesController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Specialties
        [HttpGet]
        public IActionResult GetSpecialties()
        {
            return Ok(_context.Specialty.ToList());
        }

  
        [HttpPost]
        public ActionResult<Specialty> PostSpecialty(Specialty specialty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Specialty.Add(specialty);
            _context.SaveChanges();

            return CreatedAtAction("GetSpecialties", new { id = specialty.SpecialtyID }, specialty);
        }

        // PUT: api/Specialties/{id}
        [HttpPut("{id}")]
        public IActionResult PutSpecialty(int id, [FromBody] Specialty specialty)
        {
            if (id != specialty.SpecialtyID)
            {
                return BadRequest();
            }

            _context.Entry(specialty).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Specialties/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteSpecialty(int id)
        {
            var specialty = _context.Specialty.Find(id);
            if (specialty == null)
            {
                return NotFound();
            }

            _context.Specialty.Remove(specialty);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
