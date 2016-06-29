using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfacies.Entities;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork uow;

        public QuestionService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public QuestionEntity GetQuestionEntity(int id)
        {
            throw new NotImplementedException();
        }
        public QuestionEntity GetQuestionEntityById(int? id)
        {
            if (id == null)
                return null;
            return uow.QuestionRrepository.GetById((int)id).ToBllQuestion();
        }
        public IEnumerable<QuestionEntity> GetQuestionEntityByTestId(int? testId)
        {
            if (testId == null)
                return null;
            return uow.QuestionRrepository.GetDalQuestionByTestId((int)testId).Select(q => q.ToBllQuestion());
        }
    }
}
