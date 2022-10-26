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
            BaseAddress = new Uri("https://api.energidataservice.dk/dataset/DeclarationProduction?start=2022-05-01&end=2022-06-01&filter="),
        };

        [HttpGet(Name = "GetEnergiData")]
        public List<string> Get()
        {
            List<string> strings = new List<string>();
            FileInfo file = new FileInfo("Måledata-2 år.csv");
            using (StreamReader sr = file.OpenText())
            {
                while (sr.Peek() != -1)
                {
                    strings.Add(sr.ReadLine());
                }
            }
            return strings;

        }
    }
}
