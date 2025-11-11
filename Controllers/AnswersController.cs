using Microsoft.AspNetCore.Mvc;
using StackOverflowClone.Models;
using StackOverflowClone.Services;

namespace StackOverflowClone.Controllers
{
    public class AnswersController : Controller
    {
        private readonly QAService _service;

        public AnswersController(QAService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create(int questionId)
        {
            var answer = new Answer { QuestionId = questionId };
            return View(answer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Answer a)
        {
            if (ModelState.IsValid)
            {
                a.PostedDate = DateTime.Now;
                await _service.AddAnswerAsync(a.QuestionId, a);
                return RedirectToAction("Details", "Questions", new { id = a.QuestionId });
            }
            return View(a);
        }

    }
}
