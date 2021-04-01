using API_PracticeDataLayer.Interface;
using API_PracticeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_PracticeDataLayer
{
    public class TicketDataAccess : ITicketDataAccess
    {
        private readonly TicketDbContext _dbContext;
        public TicketDataAccess(TicketDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ticket> GetTickets()
        {
            return _dbContext.Ticket.ToList();
        }

        public Ticket GetTicketById(int Id)
        {
            return _dbContext.Ticket.FirstOrDefault(e => e.TicketId == Id);  
        }

        public int AddTicket(Ticket ticket)
        {
            _dbContext.Ticket.Add(ticket);

            return _dbContext.SaveChanges();
        }

        public int EditTicket(Ticket ticket)
        {
            var ticketObj = _dbContext.Ticket.FirstOrDefault(x => x.TicketId == ticket.TicketId);
            ticketObj.TicketSubject = ticket.TicketSubject;
            ticketObj.TicketDescription = ticket.TicketDescription;
            ticketObj.UserId = ticket.UserId;
            ticketObj.IsActive = ticket.IsActive;

            _dbContext.Ticket.Update(ticketObj);
            return _dbContext.SaveChanges();
        }

        public int DeleteTicket(int Id)
        {
            var Obj = _dbContext.Ticket.FirstOrDefault(x => x.TicketId == Id);
            _dbContext.Ticket.Remove(Obj);
            return _dbContext.SaveChanges();
        }
    }
}
