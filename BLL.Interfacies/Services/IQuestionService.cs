using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface IQuestionService
    {
        QuestionEntity GetQuestionEntity(int id);
        IEnumerable<QuestionEntity> GetQuestionEntityByTestId(int? testId);
        QuestionEntity GetQuestionEntityById(int? id);
    }
}
