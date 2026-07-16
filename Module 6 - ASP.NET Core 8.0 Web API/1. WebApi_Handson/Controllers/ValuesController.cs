using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(new string[]
            {
                "Value1",
                "Value2"
            });
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok("Value : " + id);
        }




        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok("Inserted : " + value);
        }




        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(
            int id,
            [FromBody] string value)
        {
            return Ok(
                "Updated Id : " 
                + id +
                " Value : " 
                + value);
        }




        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                "Deleted Id : " + id);
        }

    }
}
