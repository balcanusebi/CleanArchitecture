using CleanArchitecture.Application.ViewModels;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IToDoService
    {
        ToDoViewModel GetToDos();

        Task Create(ToDoViewModel toDoViewModel);
    }
}
