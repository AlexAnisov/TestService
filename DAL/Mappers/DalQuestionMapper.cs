using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalQuestionMapper
    {
        public static DalQuestion ToDalQuestion(this Question question)
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
        public static Question ToQuestion(this DalQuestion question)
        {
            if (question == null)
                return null;
            return new Question()
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
