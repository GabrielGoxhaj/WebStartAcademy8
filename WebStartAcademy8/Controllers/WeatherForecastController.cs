using Microsoft.AspNetCore.Mvc;

namespace WebStartAcademy8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public void InsertEmployee()
        {
            Console.WriteLine("Sono la chiamata POST");
        }

        [HttpPut]
        public void UpdateEmployee()
        {
            Console.WriteLine("Sono la chiamata PUT");
        }

        [HttpDelete]
        public void DeleteEmployee()
        {
            Console.WriteLine("Sono la chiamata DELETE");
        }
    }
}
