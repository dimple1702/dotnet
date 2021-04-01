using API_PracticeBusinessLayer.Interface;
using API_PracticeEntities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Practice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TicketController : ControllerBase 
    {
        private readonly ITicketBusinessComponent _ticketBusinessComponent;
        
        public TicketController(ITicketBusinessComponent ticketBusinessComponent)
        {
            _ticketBusinessComponent = ticketBusinessComponent;
        }

        [HttpGet]
        public IActionResult TicketList()
        {
            var list = _ticketBusinessComponent.GetTickets();
            return Ok(list);
        }

        [HttpGet]
        public IActionResult GetTicketById(int Id)
        {
            var result = _ticketBusinessComponent.GetTicketById(Id);
            if(result == null)
            {
                return NotFound("Ticket with entered Id is not available!!");
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult AddTicket(Ticket ticket)
        {
            _ticketBusinessComponent.AddTicket(ticket);
            return Ok("Ticket Inserted!!");
        }

        [HttpDelete]
        public IActionResult DeleteTicket(int Id)
        {
            var result = _ticketBusinessComponent.DeleteTicket(Id);
            if (result == null)
            {
                return NotFound("Ticket with entered Id is not available!!");
            }
            else
            {
                return Ok("Ticket Deleted Successfully!!");
            }
        }
    }
}
