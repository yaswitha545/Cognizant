using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;

using JwtWebApi.Models;

namespace JwtWebApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    [Authorize(Roles = "Admin")]

    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees =
        new List<Employee>()
        {
            new Employee
            {
                Id=1,

                Name="John",

                Salary=50000,

                Permanent=true,

                DateOfBirth=
                new DateTime(1999,1,1),

                Department=
                new Department
                {
                    Id=101,

                    Name="IT"
                },

                Skills=
                new List<Skill>()
                {
                    new Skill
                    {
                        Id=1,

                        Name="C#"
                    }
                }
            }
        };

        [HttpGet]

        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }
    }
}
