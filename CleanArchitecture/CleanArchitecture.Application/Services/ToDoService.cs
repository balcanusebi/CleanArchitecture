using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class ToDoService : IToDoService
    {
        private IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public ToDoViewModel GetToDos()
        {
            return new ToDoViewModel
            {
                ToDos = _toDoRepository.GetToDos()
            };
        }
    }
}
