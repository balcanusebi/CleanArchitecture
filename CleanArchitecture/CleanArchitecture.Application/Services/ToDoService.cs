using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public ToDoService(IToDoRepository toDoRepository, IMediatorHandler bus, IMapper mapper)
        {
            _toDoRepository = toDoRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public async Task Create(ToDoViewModel toDoViewModel)
        {
            var createTodoCommand = _mapper.Map<CreateToDoCommand>(toDoViewModel);

            await _bus.SendCommand(createTodoCommand);
        }

        public IEnumerable<ToDoViewModel> GetToDos()
        {
            return _toDoRepository.GetToDos().ProjectTo<ToDoViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
