using API_PracticeBusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_Practice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly ITicketBusinessComponent _ticketBusinessComponent;

        public AccountController(ITicketBusinessComponent ticketBusinessComponent)
        {
            _ticketBusinessComponent = ticketBusinessComponent;
        }

        public IActionResult Login()
        {

        }
    }
}
