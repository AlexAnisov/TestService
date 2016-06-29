using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfacies.Entities;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class ResultService : IResultService
    {
        private readonly IUnitOfWork uow;

        public ResultService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
    }
}
