using Microsoft.AspNetCore.Mvc;


namespace BenthosPOC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayloadController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private static Counter _counter = new Counter();

        public PayloadController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Post(Payload payload)
        {
            lock (_counter)
            {
                _counter.Inc(1);
                Console.WriteLine($"{_counter.Value} : {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} -  Received: {payload.Id} - {payload.Content}");

            }
            return Ok();
        }
    }
}
