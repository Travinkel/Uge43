using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
    
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<string> Get()
        {
           List<string> strings = new List<string>();
            FileInfo file = new FileInfo("M�ledata-2 �r.csv");
            using(StreamReader sr = file.OpenText()) 
            {
                while(sr.Peek() != -1) 
                {
                    strings.Add(sr.ReadLine());
                }
            }return strings;
            
        }

       
    }
}