﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Entities
{
    public class TmpUserAnswerEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public bool Correct { get; set; }
        public int Cost { get; set; }
    }
}
