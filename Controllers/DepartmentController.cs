using Groep5_Van_Der_Lelie_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DbContextService _context;

        public DepartmentController(DbContextService context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Department>> Get(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetAll()
        {
            var departments = await _context.Departments.ToListAsync();

            if (departments == null)
            {
                return NotFound();
            }

            return Ok(departments);
        }

        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<object>> Update([FromBody] Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
