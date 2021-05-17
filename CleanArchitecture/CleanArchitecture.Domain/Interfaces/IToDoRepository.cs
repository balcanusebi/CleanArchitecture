using CleanArchitecture.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetToDos();
        Task Add(ToDo toDo);
    }
}
