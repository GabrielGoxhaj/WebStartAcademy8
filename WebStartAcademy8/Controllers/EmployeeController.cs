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
        private readonly SqlDbHandler _handler;
        public EmployeeController(DbParams dbParams, SqlDbHandler handler)
        {
            _params = dbParams;
            _handler = handler;        
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return _handler.GetCompleteEmployees();
        }

        [HttpGet("GetTotalEmployees")]
        public int GetCount()
        {
            return _handler.GetTotalEmployees();
        }

    }
}
