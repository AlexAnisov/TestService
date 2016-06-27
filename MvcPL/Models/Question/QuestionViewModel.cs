using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Question
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Number { get; set; }
        public int Cost { get; set; }
    }
}