using BLL.Interfacies.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class DalQuestionMapper
    {
        public static DalQuestion ToDalQuestion(this QuestionEntity question)
        {
            if (question == null)
                return null;
            return new DalQuestion()
            {
                Id = question.Id,
                Content = question.Content,
                Cost = question.Cost,
                Number = question.Number,
                TestId = question.TestId
            };
        }
        public static QuestionEntity ToBllQuestion(this DalQuestion question)
        {
            if (question == null)
                return null;
            return new QuestionEntity()
            {
                Id = question.Id,
                Content = question.Content,
                Cost = question.Cost,
                Number = question.Number,
                TestId = question.TestId
            };
        }
    }
}
