using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DayController : ControllerBase
    {
        /// <summary>
        /// Prikaže ime dneva v tednu v angleščini odvisno od vnesene številke od 1 - 7.
        /// </summary>
        /// <example>
        /// 1 = Monday, 2 = Tuesday...
        /// </example>
        /// <param name="dayNumber">Številka dneva v tednu (1 = Monday, 7 = Sunday)</param>
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
