using Microsoft.AspNetCore.Mvc;

namespace BenthosPOC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayloadController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public PayloadController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Post(Payload payload)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} -  Received: {payload.Id} - {payload.Content}");

            return Ok();

        }
    }
}
