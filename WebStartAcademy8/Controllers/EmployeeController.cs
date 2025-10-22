using Microsoft.AspNetCore.Mvc;
using DbHandler;

namespace WebStartAcademy8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController: ControllerBase
    {
        SqlDbHandler sqlDbHandler = new("");
        [HttpGet]
        public string Get()
        {
            return "Futura lista impiegati";
        }
    }
}
