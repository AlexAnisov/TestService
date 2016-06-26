using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Entities
{
    public class UserAnswerEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int QuestionAnswerId { get; set; }
        public int ResultId { get; set; }
    }
}
