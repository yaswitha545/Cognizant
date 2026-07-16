using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Filters;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>()
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
                        new Skill{ Id=1, Name="C#" },
                        new Skill{ Id=2, Name="SQL"}
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "David",
                    Salary = 60000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1999,7,15),

                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },

                    Skills = new List<Skill>()
                    {
                        new Skill{ Id=3, Name="Java"},
                        new Skill{ Id=4, Name="Python"}
                    }
                }
            };
        }

        [AllowAnonymous]
        [HttpGet]

        [ProducesResponseType(StatusCodes.Status200OK)]

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<List<Employee>> Get()
        {
            // Uncomment to test Exception Filter

            // throw new Exception("Custom Exception");

            return Ok(employees);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut]

        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}
