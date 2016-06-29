using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface IQuestionAnswerService
    {
        IEnumerable<QuestionAnswerEntity> GetQuestionAnswerEntityByQuestionId(int testId);
        QuestionAnswerEntity GetQuestionAnswerEntityById(int id);
    }
}
