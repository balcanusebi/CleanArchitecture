using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public class ToDoViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<ToDo> ToDos { get; set; }
    }
}
