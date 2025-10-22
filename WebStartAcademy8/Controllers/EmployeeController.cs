using Microsoft.AspNetCore.Mvc;
using DbHandler;
using DbHandler.DataModels;

namespace WebStartAcademy8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private SqlDbHandler sqlDbHandler;
        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
            sqlDbHandler = new(_configuration.GetConnectionString("DbAcademyOtto"));
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return sqlDbHandler.GetCompleteEmployees();
        }
    }
}
