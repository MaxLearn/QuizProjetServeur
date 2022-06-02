using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace quizExamen.Models
{
    public partial class Quiz
    {
        public Quiz()
        {
            Answer = new HashSet<Answer>();
            QuestionQuiz = new HashSet<QuestionQuiz>();
        }

        public int QuizId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Answer> Answer { get; set; }
        public virtual ICollection<QuestionQuiz> QuestionQuiz { get; set; }
    }
}
