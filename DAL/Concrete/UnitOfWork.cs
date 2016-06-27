using System;
using System.Data.Entity;
using System.Diagnostics;
using DAL.Interface.Repository;
using DAL.Interfacies.Repository;

namespace DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; private set; }
        public ITestRepository TestRepository {get; private set;}

        public UnitOfWork(DbContext context, ITestRepository testRepository)
        {
            Context = context;
            this.TestRepository = testRepository;
        }

        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}