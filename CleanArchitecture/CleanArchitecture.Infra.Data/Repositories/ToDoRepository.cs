using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private TodoDBContext _context;

        public ToDoRepository(TodoDBContext context)
        {
            _context = context;
        }

        public IEnumerable<ToDo> GetToDos()
        {
            return _context.Todos;
        }
    }
}
