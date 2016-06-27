using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfacies.Entities;
using DAL.Interface.Repository;
using BLL.Mappers;
using DAL.Interfacies.Repository;

namespace BLL.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork uow;

        public TestService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public void CreateUser(TestEntity test)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(TestEntity test)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TestEntity> GetAllTestEntity()
        {
            return uow.TestRepository.GetAll().Select(test => test.ToBllTest());
        }

        public TestEntity GetTestEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
