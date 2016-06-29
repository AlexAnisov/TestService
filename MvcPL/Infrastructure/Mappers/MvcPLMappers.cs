using BLL.Interface.Entities;
using BLL.Interfacies.Entities;
using MvcPL.Models;
using MvcPL.Models.Question;
using MvcPL.Models.Test;

namespace MvcPL.Infrastructure.Mappers
{
    public static class MvcMappers
    {
        public static UserViewModel ToMvcUser(this UserEntity userEntity)
        {
            return new UserViewModel()
            {
                Id = userEntity.Id,
                UserName = userEntity.UserName,
                Role = (Role)userEntity.RoleId
            };
        }

        public static UserEntity ToBllUser(this UserViewModel userViewModel)
        {
            return new UserEntity()
            {
                Id = userViewModel.Id,
                UserName = userViewModel.UserName,
                RoleId = (int)userViewModel.Role
            };
        }
        public static TestViewModel ToMvcTest(this TestEntity test)
        {
            if (test == null)
                return null;
            return new TestViewModel()
            {
                Id = test.Id,
                Name = test.Name,
                Number = test.Number,
                TimeToDo = test.TimeToDo
            };
        }
        public static TestEntity ToBllTest(this TestViewModel test)
        {
            if (test == null)
                return null;
            return new TestEntity()
            {
                Id = test.Id,
                Name = test.Name,
                Number = test.Number,
                TimeToDo = test.TimeToDo
            };
        }
        public static QuestionViewModel ToMVCQuestion(this QuestionEntity question)
        {
            if (question == null)
                return null;
            return new QuestionViewModel()
            {
                Id = question.Id,
                Content = question.Content,
                Cost = question.Cost,
                Number = question.Number,
                TestId = question.TestId
            };
        }
        public static QuestionEntity ToBllQuestion(this QuestionViewModel question)
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
        public static QuestionAnswerViewModel ToMvcQuestionAnswer(this QuestionAnswerEntity questionAnswer)
        {
            if (questionAnswer == null)
                return null;
            return new QuestionAnswerViewModel()
            {
                Id = questionAnswer.Id,
                Content = questionAnswer.Content,
                Correct = questionAnswer.Correct,
                QuestionId = questionAnswer.QuestionId
            };
        }
        public static QuestionAnswerEntity ToBllQuestionAnswer(this QuestionAnswerViewModel questionAnswer)
        {
            if (questionAnswer == null)
                return null;
            return new QuestionAnswerEntity()
            {
                Id = questionAnswer.Id,
                Content = questionAnswer.Content,
                Correct = questionAnswer.Correct,
                QuestionId = questionAnswer.QuestionId
            };
        }
    }
}