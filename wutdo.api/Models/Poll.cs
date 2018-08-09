﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wutdo.api.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public virtual ICollection<AnswerOption> AnswerOptions { get; set; }
    }
}
