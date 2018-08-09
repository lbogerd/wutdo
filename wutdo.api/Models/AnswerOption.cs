using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wutdo.api.Models
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public int? Order { get; set; }
        public string AnswerText { get; set; }

        public virtual Poll Poll { get; set; }
    }
}
