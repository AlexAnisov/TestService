﻿using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalUserAnswerMapper
    {
        public static DalUserAnswer ToDalResult(this UserAnswer userAnswer)
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
        public static UserAnswer ToResult(this DalUserAnswer userAnswer)
        {
            if (userAnswer == null)
                return null;
            return new UserAnswer()
            {
                Id = userAnswer.Id,
                ResultId = userAnswer.ResultId,
                QuestionId = userAnswer.QuestionId,
                QuestionAnswerId = userAnswer.QuestionAnswerId
            };
        }
    }
}
