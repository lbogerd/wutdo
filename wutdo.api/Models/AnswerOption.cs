using Newtonsoft.Json;
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

        [JsonIgnore]
        public int PollId { get; set; }
        [JsonIgnore]
        public virtual Poll Poll { get; set; }
    }
}
