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

        public int Number { get; set; }
        public long TimeToDo { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Test()
        {
            Questions = new HashSet<Question>();
        }
    }
}
