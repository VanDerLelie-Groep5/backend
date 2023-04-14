using Groep5_Van_Der_Lelie_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DbContextService context;

        public EmployeeController(DbContextService context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
            var employees = await this.context.Employees.ToListAsync();

            return Ok(employees);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Create([FromBody] Employee employee)
        {
            this.context.Employees.Add(employee);
            await this.context.SaveChangesAsync();

            return Ok(employee);
        }
    }
}
