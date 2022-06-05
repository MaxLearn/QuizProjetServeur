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

        public IActionResult SaveResponse( response)
        {
            
            return View();
        }
        public IActionResult AfficherQuestions(int quizChoice)
        {
           Console.WriteLine("hello my name is :" + quizChoice);


            string userName = context.Quiz.Find(quizChoice).UserName;

           var listeQuizQuestions = context.QuestionQuiz.Where(c => c.QuizId == quizChoice).ToList();

    List <Question> listeQuestions = new List<Question>();

            List<ItemOption> listeOptions = new List<ItemOption>();
            
       foreach(QuestionQuiz element in listeQuizQuestions)
    {
            listeQuestions.Add(context.Question.Find(element.QuestionId));
            System.Diagnostics.Debug.WriteLine(element.QuestionId);

                listeOptions.AddRange(context.ItemOption.Where(i => i.QuestionId == element.QuestionId).ToList());
            }
            Console.WriteLine(listeOptions[0].Text);
            ViewBag.listeOptions = listeOptions;
            ViewBag.message = "Quiz numéro " + quizChoice + " de l'utilisateur " + userName ;
            ViewBag.style = "text-success";
                
           return View(listeQuestions);


}

    public IActionResult PasserQuiz(string name, string email)
        {
            if (name != null && email != null)
            {
                var listeQuiz = context.Quiz.Where(c => c.UserName == name && c.Email == email).ToList();
                if (listeQuiz.Count > 0)
                {
                    ViewBag.message = listeQuiz.Count + "Nombre de quiz trouvé(s) pour l'utilisateur: Username :" + name + " Email : " + email;
                    ViewBag.style = "text-success";
                }
                else
                {
                    ViewBag.message = listeQuiz.Count + " Pas de résultat pour l'utilisateur:  Username :" + name + " Email : " + email; ;
                    ViewBag.style = "text-danger";
                }
                return View(listeQuiz);
            }

            return View();
        }

        public int PasserQuestionsParCategory(int category)
        {
        
                var listeQuestions = context.Question.Where(question => question.CategoryId == category).ToList();

            Random rnd = new Random();

            int questionIndex = rnd.Next(listeQuestions.Count);
            var question = listeQuestions.ElementAt(questionIndex);


            return (int)question.QuestionId;

            
        }

        private object Random(object length)
        {
            throw new NotImplementedException();
        }

        public IActionResult CreateQuiz(string name, string email, int nbrEasy, int nbrMedium, int nbrHard)
        {
            Quiz user = new Quiz();
            user.UserName = name;
            user.Email = email;
            context.Add<Quiz>(user);
            context.SaveChanges();
                   
            //DOUBLONS POSSIBLE
                for (int i = 0; i < nbrEasy; i++)
                {
                QuestionQuiz questionQuiz = new QuestionQuiz();
                questionQuiz.QuizId = user.QuizId;
                questionQuiz.QuestionId = PasserQuestionsParCategory(1);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }
                
            for (int i = 0; i < nbrMedium; i++)
                {
                QuestionQuiz questionQuiz = new QuestionQuiz();
                questionQuiz.QuizId = user.QuizId;
                questionQuiz.QuestionId = PasserQuestionsParCategory(2);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }
                
            for (int i = 0; i < nbrHard; i++)
                {
                QuestionQuiz questionQuiz = new QuestionQuiz();
                questionQuiz.QuizId = user.QuizId;
                questionQuiz.QuestionId = PasserQuestionsParCategory(3);
                context.Add<QuestionQuiz>(questionQuiz);
                context.SaveChanges();
                }

            return View();

        }
    }


}

