using Microsoft.AspNetCore.Mvc;

namespace ProductStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "✔️ Docker Compose CI/CD working!", "Updated from pipeline 🚀" };
        }

        // ❌ Remove or comment out any extra [HttpGet] methods like this:
        // [HttpGet]
        // public IEnumerable<string> GetSomethingElse()
        // {
        //     return new string[] { "This causes conflict!" };
        // }
    }
}