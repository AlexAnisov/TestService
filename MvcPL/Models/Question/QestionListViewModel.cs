using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Question
{
    
    public class QestionListViewModel
    {
        public IEnumerable<QuestionViewModel> Questions { get; set; }
        public CountOfQuestionsInfo PagingInfo { get; set; }
    }
}