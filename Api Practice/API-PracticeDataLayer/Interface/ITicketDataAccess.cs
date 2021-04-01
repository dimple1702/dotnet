using API_PracticeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_PracticeDataLayer.Interface
{
    public interface ITicketDataAccess
    {
        List<Ticket> GetTickets();
        Ticket GetTicketById(int Id);
        int AddTicket(Ticket ticket);
        int EditTicket(Ticket ticket);
        int DeleteTicket(int Id);

    }
}
