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
    public class SpecaltiesController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public SpecaltiesController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Specialty>>> GetSpecalty()
        {
            return await _context.Specialty.ToListAsync();
        }

        // GET: Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Specialty>> GetSpecalty(int id)
        {
            var Specialty = await _context.Specialty.FindAsync(id);

            if (Specialty == null)
            {
                return NotFound();
            }

            return Specialty;
        }

    }
}
