using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiCourses.Data;
using WebApiCourses.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly WebApiCoursesContext _context;

        public GroupsController(WebApiCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public ActionResult<IEnumerable<Group>> GetGroups()
        {
            return _context.Group.ToList();
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public ActionResult<Group> GetGroup(int id)
        {
            var group = _context.Group.Find(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public IActionResult PutGroup(int id, Group group)
        {
            if (id != group.GroupID)
            {
                return BadRequest();
            }

            _context.Entry(group).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // POST: api/Groups
        [HttpPost]
        public ActionResult<Group> PostGroup(Group group)
        {
            _context.Group.Add(group);
            _context.SaveChanges();

            return CreatedAtAction("GetGroup", new { id = group.GroupID }, group);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public IActionResult DeleteGroup(int id)
        {
            var group = _context.Group.Find(id);
            if (group == null)
            {
                return NotFound();
            }

            _context.Group.Remove(group);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
