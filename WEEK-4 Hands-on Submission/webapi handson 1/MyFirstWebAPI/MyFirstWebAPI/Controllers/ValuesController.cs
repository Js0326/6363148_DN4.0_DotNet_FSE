using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> values = new() { "Item1", "Item2", "Item3" };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound("Item not found");

            return Ok(values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return CreatedAtAction(nameof(Get), new { id = values.Count - 1 }, value);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string updatedValue)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid index");

            values[id] = updatedValue;
            return Ok(updatedValue);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid index");

            values.RemoveAt(id);
            return NoContent();
        }
    }
}
