using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDo> ToDos { get; set; }
    }
}
