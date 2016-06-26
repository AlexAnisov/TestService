using BLL.Interfacies.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllUserAnswerMapper
    {
        public static DalUserAnswer ToDalResult(this UserAnswerEntity userAnswer)
        {
            if (userAnswer == null)
                return null;
            return new DalUserAnswer()
            {
                Id = userAnswer.Id,
                ResultId = userAnswer.ResultId,
                QuestionId = userAnswer.QuestionId,
                QuestionAnswerId = userAnswer.QuestionAnswerId
            };
        }
        public static UserAnswerEntity ToBllResult(this DalUserAnswer userAnswer)
        {
            if (userAnswer == null)
                return null;
            return new UserAnswerEntity()
            {
                Id = userAnswer.Id,
                ResultId = userAnswer.ResultId,
                QuestionId = userAnswer.QuestionId,
                QuestionAnswerId = userAnswer.QuestionAnswerId
            };
        }
    }
}
