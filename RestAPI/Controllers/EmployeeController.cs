using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            // Sample data for demonstration purposes
            var employees = new[]
            {
                new { Id = 1, Name = "John Doe", Position = "Software Engineer" },
                new { Id = 2, Name = "Jane Smith", Position = "Project Manager" },
                new { Id = 3, Name = "Mike Johnson", Position = "QA Analyst" }
            };
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            // Sample data for demonstration purposes
            var employee = new { Id = id, Name = "John Doe", Position = "Software Engineer" };
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] object employee)
        {
            // Logic to create a new employee
            return CreatedAtAction(nameof(GetEmployeeById), new { id = 1 }, employee);
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] object employee)
        {
            // Logic to update an existing employee
            return NoContent();
        }

    }
}
