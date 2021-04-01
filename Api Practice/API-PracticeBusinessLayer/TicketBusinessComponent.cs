using API_PracticeBusinessLayer.Interface;
using API_PracticeDataLayer.Interface;
using API_PracticeEntities.Entities;
using System;
using System.Collections.Generic;

namespace API_PracticeBusinessLayer
{
    public class TicketBusinessComponent : ITicketBusinessComponent
    {
        private readonly ITicketDataAccess _ticketDataComponent;

        public TicketBusinessComponent(ITicketDataAccess ticketDataComponent)
        {
            _ticketDataComponent = ticketDataComponent;
        }

        public List<Ticket> GetTickets()
        {
            return _ticketDataComponent.GetTickets();
        }

        public Ticket GetTicketById(int Id)
        {
            return _ticketDataComponent.GetTicketById(Id);
        }


        public int AddTicket(Ticket ticket)
        {
            return _ticketDataComponent.AddTicket(ticket);
        }

        public int EditTicket(Ticket ticket)
        {
            return _ticketDataComponent.EditTicket(ticket);
        }

        public int DeleteTicket(int Id)
        {
            return _ticketDataComponent.DeleteTicket(Id);
        }
                
    }
}
