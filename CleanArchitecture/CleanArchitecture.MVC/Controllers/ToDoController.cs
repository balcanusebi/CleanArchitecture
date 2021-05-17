using CleanArchitecture.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.MVC.Controllers
{
    [Authorize]
    public class ToDoController : Controller
    {
        private IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult Index()
        {
            var model = _toDoService.GetToDos();

            return View(model);
        }
    }
}
