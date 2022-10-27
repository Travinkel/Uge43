using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://api.energidataservice.dk/meta/Dataset"),
        };

        [HttpGet(Name = "GetEnergiData")]
        public List<string> Get()
        {
            

        }
    }
}
