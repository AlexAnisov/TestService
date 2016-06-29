using BLL.Interfacies.Entities;
using BLL.Interfacies.Services;
using MvcPL.Infrastructure.Mappers;
using MvcPL.Models;
using MvcPL.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Controllers
{
    public class QuestionController : Controller
    {
        private IQuestionService QuestionService;
        private IQuestionAnswerService QuestionAnswerService;
        private IUserAnswerService UserAnswerService;

        public int PageSize = 1;

        public QuestionController(IQuestionService questionService, IQuestionAnswerService questionAnswerService, 
            IUserAnswerService userAnswerService)
        {
            this.QuestionService = questionService;
            this.QuestionAnswerService = questionAnswerService;
            this.UserAnswerService = userAnswerService;
        }
        public ActionResult BeginTest(int? testId = null, int page = 1)
        {
            if (testId == null)
            {
                return RedirectToAction("List", "Test");
            }
            int currentQusetionId = QuestionService.GetQuestionEntityByTestId(testId).Where(q => q.Number == page).Select(q => q.ToMVCQuestion()).First().Id;
            QestionListViewModel model = new QestionListViewModel
            {
                Questions = QuestionService.GetQuestionEntityByTestId(testId)
                .OrderBy(p => p.Number)
                .Skip((page - 1) * PageSize)
                .Take(PageSize).Select(q => q.ToMVCQuestion()),
                QuestionInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = QuestionService.GetQuestionEntityByTestId(testId).Select(q => q.ToMVCQuestion()).Count()
                },
                QuestionAnswers = QuestionAnswerService.GetQuestionAnswerEntityByQuestionId(currentQusetionId)
                .Select(qa => qa.ToMvcQuestionAnswer()),
            };
            return View(model);
        }
        public ActionResult SetAnswer (int Id, int questionId, string returnUrl)
        {
            GetTmpUserAnswer().AddTmpItem(Id, questionId);
            return Redirect(returnUrl);
        }
        private ISessionUserAnswerService GetTmpUserAnswer()
        {
            ISessionUserAnswerService TmpUserAnswer = (ISessionUserAnswerService)Session["TmpUserAnswer"];
            if (TmpUserAnswer == null)
            {
                TmpUserAnswer = UserAnswerService.CreateNewSessionAnswer();
                Session["TmpUserAnswer"] = TmpUserAnswer;
            }
            return TmpUserAnswer;
        }
    }
}
