using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System.Collections.Generic;
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

        public IEnumerable<ToDo> GetToDos()
        {
            return _context.Todos;
        }
    }
}
