using Groep5_Van_Der_Lelie_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DbContextService _context;

        public OrderController(DbContextService context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Order>>> Get(int id)
        {
            var order = await _context.Orders
                .Where(o => o.Id == id)
                .Include(o => o.Shift)
                .ToListAsync();

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAll()
        {
            var orders = await _context.Orders
                .Include(o => o.Shift)
                .ToListAsync();

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<object>> Update([FromBody] Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
