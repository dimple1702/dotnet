using ApiPracticeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPracticeDataLayer.Interface
{
    public interface IApiPracticeDataAccess
    {
        List<User> GetUsers();
        List<Ticket> GetTickets();
        Ticket GetTicketById(int Id);
        int AddTicket(Ticket ticket);
        int EditTicket(Ticket ticket);
        int DeleteTicket(int Id);
    }
}
