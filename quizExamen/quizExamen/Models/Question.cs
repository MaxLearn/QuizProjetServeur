using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace quizExamen.Models
{
    public partial class Question
    {
        public Question()
        {
            ItemOption = new HashSet<ItemOption>();
            QuestionQuiz = new HashSet<QuestionQuiz>();
        }

        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ItemOption> ItemOption { get; set; }
        public virtual ICollection<QuestionQuiz> QuestionQuiz { get; set; }
    }
}
