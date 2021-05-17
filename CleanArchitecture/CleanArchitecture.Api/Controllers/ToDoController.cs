using CleanArchitecture.Application.Services;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ToDoViewModel todoViewModel)
        {
            await _toDoService.Create(todoViewModel);

            return Ok(todoViewModel);
        }
    }
}
