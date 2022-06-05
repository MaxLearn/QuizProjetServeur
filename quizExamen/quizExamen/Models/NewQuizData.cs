using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizExamen.Models
{
    public partial class NewQuizData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NbrEasy { get; set; }
        public int NbrMedium { get; set; }
        public int NbrHard { get; set; }
    }
}
