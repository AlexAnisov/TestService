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

        public IUserAnswerRepository UserAnswerRepository { get; private set; }

        public IResultRepository ResultRepository { get; private set; }

        public IQuestionRepository QuestionRrepository { get; private set; }

        public IQuestionAnswerRepository QuestionAnswerRepository { get; private set; }

        public UnitOfWork(DbContext context, ITestRepository testRepository, IUserAnswerRepository userAnswerRepository,
            IResultRepository resultRepository, IQuestionRepository questionRrepository, 
            IQuestionAnswerRepository questionAnswerRepository)
        {
            Context = context;
            this.TestRepository = testRepository;
            this.ResultRepository = resultRepository;
            this.UserAnswerRepository = userAnswerRepository;
            this.QuestionRrepository = questionRrepository;
            this.QuestionAnswerRepository = questionAnswerRepository;
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