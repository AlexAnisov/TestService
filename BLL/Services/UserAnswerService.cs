using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfacies.Entities;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUnitOfWork uow;
        
        
        public UserAnswerService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public ISessionUserAnswerService CreateNewSessionAnswer()
        {
            SessionUserAnswerService tmpUserAnswer= new SessionUserAnswerService();
            return tmpUserAnswer;
        }
        
    }
}
