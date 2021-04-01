using API_PracticeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_PracticeBusinessLayer.Interface
{
    public interface ITicketBusinessComponent
    {
        List<Ticket> GetTickets();
        Ticket GetTicketById(int Id);
        int AddTicket(Ticket ticket);
        int EditTicket(Ticket ticket);
        int DeleteTicket(int Id);
    }
}
