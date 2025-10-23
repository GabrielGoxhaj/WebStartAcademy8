using Microsoft.AspNetCore.Mvc;
using WebStartAcademy8.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStartAcademy8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkdayController : ControllerBase
    {
        private readonly DbParams _dbParams;

        public WorkdayController(DbParams dbParams)
        {
            _dbParams = dbParams;
        }


        // GET: api/<WorkdayController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WorkdayController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value: {id * id}";
        }

        // POST api/<WorkdayController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WorkdayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkdayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
