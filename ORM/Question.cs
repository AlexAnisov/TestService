using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public int Number { get; set; }
        [Required]
        public int Cost { get; set; }
        public int TestId { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public Question()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
        }
    }
}
