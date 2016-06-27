using DAL.Interfacies.Repository;
using System;

namespace DAL.Interface.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository TestRepository { get; }
        void Commit();
        //Rollback
    }
}