using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace quizExamen.Models
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public int? OptionId { get; set; }
        public int? QuizId { get; set; }

        public virtual ItemOption Option { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
