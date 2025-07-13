using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using EmployeeApiProject.Models;    
using EmployeeApiProject.Filters;    

namespace EmployeeApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter] 
    public class EmployeeController : ControllerBase
    {
        private readonly List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            };
        }

        [HttpGet("standard")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(500)]
        public ActionResult<Employee> GetStandard()
        {
            throw new Exception("Test exception handling"); // for exception filter testing
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            return Ok($"Received employee: {emp.Name}");
        }
    }
}
