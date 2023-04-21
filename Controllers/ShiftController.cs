using Groep5_Van_Der_Lelie_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private readonly DbContextService _context;

        public ShiftController(DbContextService context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Shift>>> Get(int id)

            
        {
            var shift = await _context.Shifts
                .Where(o => o.Id == id)
                .ToListAsync();

            if (shift == null)
            {
                return NotFound();
            }

            return Ok(shift);
        }

        [HttpGet]
        public async Task<ActionResult<List<Shift>>> GetAll()
        {
            var shifts = await _context.Shifts.ToListAsync();

            if (shifts == null)
            {
                return NotFound();
            }

            return Ok(shifts);
        }

        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] Shift shift)
        {
            _context.Shifts.Add(shift);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<object>> Update([FromBody] Shift shift)
        {
            _context.Shifts.Update(shift);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
