using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IToDoService
    {
        IEnumerable<ToDoViewModel> GetToDos();

        Task Create(ToDoViewModel toDoViewModel);
    }
}
