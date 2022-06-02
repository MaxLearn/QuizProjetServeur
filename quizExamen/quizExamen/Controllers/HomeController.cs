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
        public IActionResult CreateQuiz(string pattern)
        {
            if(pattern != null)
            {
                // "facile=1;moyen=2;difficile=1;"


            }
        }
    }


}

