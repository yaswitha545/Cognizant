using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(1998,5,10),

                Department = new Department
                {
                    Id = 101,
                    Name = "IT"
                },

                Skills = new List<Skill>()
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                }
            },

            new Employee
            {
                Id = 2,
                Name = "David",
                Salary = 60000,
                Permanent = false,
                DateOfBirth = new DateTime(1999,8,20),

                Department = new Department
                {
                    Id = 102,
                    Name = "HR"
                },

                Skills = new List<Skill>()
                {
                    new Skill{Id=3,Name="Java"}
                }
            }
        };

        // GET
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        // PUT
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            // Check invalid id
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Find employee
            Employee emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee details
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;
            emp.DateOfBirth = employee.DateOfBirth;

            return Ok(emp);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(emp);

            return Ok("Employee Deleted Successfully");
        }
    }
}
