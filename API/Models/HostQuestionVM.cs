using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class HostQuestionVM
    {
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
