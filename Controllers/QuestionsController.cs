using Microsoft.AspNetCore.Mvc;
using StackOverflowClone.Models;
using StackOverflowClone.Services;

namespace StackOverflowClone.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly QAService _service;

        public QuestionsController(QAService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var questions = await _service.GetAllQuestionsAsync();
            return View(questions);
        }

        public async Task<IActionResult> Details(int id)
        {
            var question = await _service.GetQuestionByIdAsync(id);
            if (question == null) return NotFound();
            return View(question);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Question q)
        {
            if (ModelState.IsValid)
            {
                q.PostedDate = DateTime.Now;
                await _service.AddQuestionAsync(q);
                return RedirectToAction("Index");
            }
            return View(q);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteQuestionAsync(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAnswer(int questionId, string body, string postedBy)
        {
            if (string.IsNullOrWhiteSpace(body))
            {
                ModelState.AddModelError("", "Answer body cannot be empty.");
            }

            if (ModelState.IsValid)
            {
                var answer = new Answer
                {
                    Body = body,
                    PostedBy = postedBy,
                    PostedDate = DateTime.Now
                };
                await _service.AddAnswerAsync(questionId, answer);
                return RedirectToAction("Details", new { id = questionId });
            }

            var q = await _service.GetQuestionByIdAsync(questionId);
            return View("Details", q);
        }
    }
}
