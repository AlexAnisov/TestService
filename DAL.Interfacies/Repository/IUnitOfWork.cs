using DAL.Interfacies.Repository;
using System;

namespace DAL.Interface.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository TestRepository { get; }
        IUserAnswerRepository UserAnswerRepository { get; }
        IResultRepository ResultRepository { get; }
        IQuestionRepository QuestionRrepository { get; }
        IQuestionAnswerRepository QuestionAnswerRepository { get; }
        void Commit();
        //Rollback
    }
}