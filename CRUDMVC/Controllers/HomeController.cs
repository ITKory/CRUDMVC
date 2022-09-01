using CRUDMVC.Models;
using CRUDMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TaskService _tasks;
        public HomeController(ILogger<HomeController> logger, TaskService taskService)
        {
            _logger = logger;
            _tasks = taskService;
        }

        public IActionResult Index()
        {
            ViewBag.Tasks = _tasks.GetTasks();

            return View(new Taska());
        }

        public IActionResult Delete(string newTaskText, string newTaskStatus, int id)
        {
            _tasks.RemoveTask(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddTask(string text)
        {
            _tasks.AddTask(text);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult UpdateTask(string newTaskText, string newTaskStatus, int id)
        {
           _tasks.UpdateTask(id,newTaskText,newTaskStatus);
            return RedirectToAction(nameof(Index));

        }


    }
}