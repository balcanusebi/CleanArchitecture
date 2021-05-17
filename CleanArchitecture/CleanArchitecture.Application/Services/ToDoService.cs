using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ToDoService : IToDoService
    {
        private IToDoRepository _toDoRepository;
        private readonly IMediatorHandler _bus;

        public ToDoService(IToDoRepository toDoRepository, IMediatorHandler bus)
        {
            _toDoRepository = toDoRepository;
            _bus = bus;
        }

        public async Task Create(ToDoViewModel toDoViewModel)
        {
            var createTodoCommand = new CreateToDoCommand(toDoViewModel.Name, toDoViewModel.Description, toDoViewModel.ImageUrl);

            await _bus.SendCommand(createTodoCommand);
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
