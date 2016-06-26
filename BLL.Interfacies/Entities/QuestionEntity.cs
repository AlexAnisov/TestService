using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Entities
{
    public class QuestionEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Number { get; set; }
        public int Cost { get; set; }
        public int TestId { get; set; }
    }
}
