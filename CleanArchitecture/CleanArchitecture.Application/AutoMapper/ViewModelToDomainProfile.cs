using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;

namespace CleanArchitecture.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ToDoViewModel, CreateToDoCommand>()
                .ConstructUsing(c => new CreateToDoCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
