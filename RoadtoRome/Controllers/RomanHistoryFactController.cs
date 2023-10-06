using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoadtoRome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RomanHistoryFactController : ControllerBase
    {

        // GET: api/<RomanHistoryFactController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RomanHistoryFactController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RomanHistoryFactController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RomanHistoryFactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RomanHistoryFactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
