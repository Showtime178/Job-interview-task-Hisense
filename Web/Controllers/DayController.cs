using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DayController : ControllerBase
    {
        [HttpGet("{dayNumber}")]
        public IActionResult GetDay(int dayNumber)
        {
            var days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayNumber < 1 || dayNumber > 7)
                return BadRequest("Napačna številka dneva, mora bit me 1 in 7.");

            return Ok(days[dayNumber - 1]);
        }
    }
}
