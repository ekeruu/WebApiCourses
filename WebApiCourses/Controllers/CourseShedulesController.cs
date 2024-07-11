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
    public class CourseSheduleController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public CourseSheduleController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseShedule>>> GetCourseShedule()
        {
            return await _context.CourseShedule.ToListAsync();
        }

        // GET: Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseShedule>> GetCourseShedule(int id)
        {
            var courseShedule = await _context.CourseShedule.FindAsync(id);

            if (courseShedule == null)
            {
                return NotFound();
            }

            return courseShedule;
        }

    }
}
