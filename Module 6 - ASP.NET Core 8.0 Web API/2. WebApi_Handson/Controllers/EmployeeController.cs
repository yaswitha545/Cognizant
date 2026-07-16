using Microsoft.AspNetCore.Mvc;


namespace SwaggerDemo.Controllers
{


[Route("api/[controller]")]
[ApiController]


public class EmployeeController 
: ControllerBase
{



static List<string> employees =
new List<string>()
{

"John",

"David",

"Smith"

};





// GET Employee List

[HttpGet]


public IActionResult GetEmployee()
{


return Ok(employees);


}






// POST Add Employee


[HttpPost]


public IActionResult AddEmployee(
[FromBody]string name)
{


employees.Add(name);


return Ok(
"Employee Added Successfully");


}




// DELETE Employee


[HttpDelete("{id}")]


public IActionResult DeleteEmployee(
int id)
{


employees.RemoveAt(id);


return Ok(
"Employee Deleted");


}




}

}
