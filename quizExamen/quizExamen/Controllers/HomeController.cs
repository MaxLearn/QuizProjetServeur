using Microsoft.AspNetCore.Mvc;
using quizExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizExamen.Controllers
{
    public class HomeController : Controller
    {
        public readonly QuizExamenContext context;
        public HomeController(QuizExamenContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult PasserQuiz(string pattern)
        {
            if (pattern != null)
            {
                var user = context.Quiz.Where(q => q.UserName.Contains(pattern)).ToList();

                return View(user);
            }
            return View();
        }

        public int PasserQuestionsParCategory(int category)
        {
        
                var listeQuestions = context.Question.Where(question => question.CategoryId == category).ToList();

            Random rnd = new Random();

            int questionIndex = rnd.Next(listeQuestions.Count);
            var question = listeQuestions.ElementAt(questionIndex);


            return (int)question.CategoryId;

            
        }

        private object Random(object length)
        {
            throw new NotImplementedException();
        }

        public IActionResult CreateQuiz(string name, string email, int easy, int medium, int hard)
        {            
                Quiz quiz = new Quiz();
                quiz.UserName = name;
                quiz.Email = email;

                context.Add<Quiz>(quiz);
                context.SaveChanges();

                var newUserId = context.Quiz.Find(name);

                
                for (int i = 0; i < easy; i++)
                {
                    QuestionQuiz questionQuiz = new QuestionQuiz();
                    questionQuiz.QuizId = quiz.QuizId;
                    questionQuiz.QuestionId = PasserQuestionsParCategory(1);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }
                
            for (int i = 0; i < medium; i++)
                {
                QuestionQuiz questionQuiz = new QuestionQuiz();
                questionQuiz.QuizId = quiz.QuizId;
                questionQuiz.QuestionId = PasserQuestionsParCategory(2);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }
                
            for (int i = 0; i < hard; i++)
                {
                QuestionQuiz questionQuiz = new QuestionQuiz();
                questionQuiz.QuizId = quiz.QuizId;
                questionQuiz.QuestionId = PasserQuestionsParCategory(3);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }


            return View();


        }
    }


}

