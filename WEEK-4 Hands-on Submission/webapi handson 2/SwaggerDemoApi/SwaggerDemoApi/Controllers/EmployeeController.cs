using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SwaggerDemoApi.Controllers
{
    [ApiController]
    [Route("api/emp")]  // ← Changed to match assignment
    public class EmployeeController : ControllerBase
    {
        private static readonly List<string> employees = new() { "John", "Jane", "Mark" };

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            return Ok(employees[id]);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] string name)
        {
            employees.Add(name);
            return CreatedAtAction(nameof(GetById), new { id = employees.Count - 1 }, name);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest("Invalid ID");

            employees.RemoveAt(id);
            return NoContent();
        }
    }
}
