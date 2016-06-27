using DAL.Interfacies.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using System.Data.Entity;
using ORM;
using DAL.Mappers;

namespace DAL.Concrete
{
    public class TestRepository : ITestRepository
    {
        private DbContext context;
        public TestRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalTest e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalTest> GetAll()
        {
            return context.Set<Test>().ToList().Select(t=>t.ToDalTest());
        }

        public DalTest GetById(int key)
        {
            throw new NotImplementedException();
        }

        public void Update(DalTest entity)
        {
            throw new NotImplementedException();
        }
    }
}
