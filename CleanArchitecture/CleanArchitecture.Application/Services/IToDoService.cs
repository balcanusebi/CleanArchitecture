using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public interface IToDoService
    {
        IEnumerable<ToDoViewModel> GetToDos();
    }
}
