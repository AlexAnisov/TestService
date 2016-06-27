using MvcPL.Infrastructure;

namespace MvcPL.Models.Question
{
    public class CountOfQuestionsInfo : IPagingInfo
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
    }
}