using Microsoft.AspNetCore.Mvc;


namespace SwaggerDemo.Controllers
{

[Route("api/[controller]")]
[ApiController]


public class ValuesController : ControllerBase
{


// GET : api/Values


[HttpGet]

[ProducesResponseType(StatusCodes.Status200OK)]

public IActionResult Get()
{

    string[] values =
    {
        "Value1",
        "Value2"
    };


    return Ok(values);

}





// GET : api/Values/5


[HttpGet("{id}")]


public IActionResult Get(int id)
{


    return Ok(
        "Value = " + id);

}






// POST : api/Values


[HttpPost]


public IActionResult Post(
    [FromBody]string value)
{


    return Ok(
        "Inserted : " + value);

}







// PUT : api/Values/5


[HttpPut("{id}")]


public IActionResult Put(
int id,
[FromBody]string value)
{


return Ok(
"Updated ID : "
+ id +
" Value : "
+ value);


}







// DELETE : api/Values/5


[HttpDelete("{id}")]


public IActionResult Delete(int id)
{


return Ok(
"Deleted ID : "
+ id);


}



}

}
