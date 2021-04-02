using ApiPracticeBusinessLayer.Interface;
using ApiPracticeDataLayer.Interface;
using ApiPracticeEntities.Entities;
using System;
using System.Collections.Generic;

namespace ApiPracticeBusinessLayer
{
    public class ApiPracticeBusinessComponent : IApiPracticeBusinessComponent
    {
        private readonly IApiPracticeDataAccess _apiPracticeDataAccess;

        public ApiPracticeBusinessComponent(IApiPracticeDataAccess apiPracticeDataAccess)
        {
            _apiPracticeDataAccess = apiPracticeDataAccess;
        }

        public List<User> GetUsers()
        {
            return _apiPracticeDataAccess.GetUsers();
        }

        public List<Ticket> GetTickets()
        {
            return _apiPracticeDataAccess.GetTickets();
        }

        public Ticket GetTicketById(int Id)
        {
            return _apiPracticeDataAccess.GetTicketById(Id);
        }


        public int AddTicket(Ticket ticket)
        {
            return _apiPracticeDataAccess.AddTicket(ticket);
        }

        public int EditTicket(Ticket ticket)
        {
            return _apiPracticeDataAccess.EditTicket(ticket);
        }

        public int DeleteTicket(int Id)
        {
            return _apiPracticeDataAccess.DeleteTicket(Id);
        }
    }
}
