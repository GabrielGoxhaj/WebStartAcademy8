using Microsoft.AspNetCore.Mvc;
using DbHandler;
using DbHandler.DataModels;
using WebStartAcademy8.Models;

namespace WebStartAcademy8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DbParams _params;
        private SqlDbHandler sqlDbHandler;
        public EmployeeController(DbParams dbParams)
        {
            _params = dbParams;
            sqlDbHandler = new(_params.SqlConnectionString);
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return sqlDbHandler.GetCompleteEmployees();
        }
    }
}
