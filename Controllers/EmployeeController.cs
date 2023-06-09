﻿using Groep5_Van_Der_Lelie_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DbContextService _context;

        public EmployeeController(DbContextService context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
            var employees = await _context.Employees.ToListAsync();

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<object>> Update([FromBody] Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
