using ApiPracticeBusinessLayer.Interface;
using ApiPracticeEntities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPractice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TicketController : ControllerBase
    {
        private readonly IApiPracticeBusinessComponent _apiPracticeBusinessComponent;

        public TicketController(IApiPracticeBusinessComponent apiPracticeBusinessComponent)
        {
            _apiPracticeBusinessComponent = apiPracticeBusinessComponent;
        }

        [HttpGet]
        [Authorize(Roles = "dev")]
        public IActionResult TicketList()
        {
            var list = _apiPracticeBusinessComponent.GetTickets();
            return Ok(list);
        }

        [HttpGet]
        [Authorize(Roles = "Developer")]
        public IActionResult GetTicketById(int Id)
        {
            var result = _apiPracticeBusinessComponent.GetTicketById(Id);
            if (result == null)
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
            _apiPracticeBusinessComponent.AddTicket(ticket);
            return Ok("Ticket Inserted!!");
        }

        [HttpDelete]
        public IActionResult DeleteTicket(int Id)
        {
            var result = _apiPracticeBusinessComponent.DeleteTicket(Id);
            if (result == 0)
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
