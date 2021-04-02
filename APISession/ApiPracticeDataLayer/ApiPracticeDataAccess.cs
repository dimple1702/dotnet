using ApiPracticeDataLayer.Interface;
using ApiPracticeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiPracticeDataLayer
{
    public class ApiPracticeDataAccess : IApiPracticeDataAccess
    {
        private readonly ApiPracticeDbContext _dbContext;
        public ApiPracticeDataAccess(ApiPracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            var list = _dbContext.User.ToList();
             return list;
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
            if(Obj == null)
            {
                return 0;
            }
            else
            {
                _dbContext.Ticket.Remove(Obj);
                return _dbContext.SaveChanges();
            }
        }
    }
}
