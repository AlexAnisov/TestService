using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Test
    {
        public int Id { get; set; }

        public string Number { get; set; }

        [Required]
        public int Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Test()
        {
            Questions = new HashSet<Question>();
        }
    }
}
