using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private TodoDBContext _context;

        public ToDoRepository(TodoDBContext context)
        {
            _context = context;
        }

        public async Task Add(ToDo toDo)
        {
            await _context.AddAsync(toDo);
            await _context.SaveChangesAsync();
        }

        public IQueryable<ToDo> GetToDos()
        {
            return _context.Todos.AsQueryable();
        }
    }
}
