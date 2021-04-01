using Microsoft.AspNetCore.Mvc;

namespace API_Practice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TicketController : Controller
    {
        [HttpGet]
        public IActionResult GetTicket()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateTicket()
        {
            return Ok();
        }
    }
}
