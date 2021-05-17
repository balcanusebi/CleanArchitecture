using CleanArchitecture.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IToDoRepository
    {
        IQueryable<ToDo> GetToDos();
        Task Add(ToDo toDo);
    }
}
