using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.CommandHandlers
{
    public class ToDoCommandHandler : IRequestHandler<CreateToDoCommand, bool>
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoCommandHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<bool> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var todo = new ToDo
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            await _toDoRepository.Add(todo);

            return true;
        }
    }
}
