using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.CommandHandlers;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Bus;
using CleanArchitecture.Infra.Data.Context;
using CleanArchitecture.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer 
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MetiatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateToDoCommand, bool>, ToDoCommandHandler>();

            //Application Layer
            services.AddScoped<IToDoService, ToDoService>();

            //Infra.Data Layer
            services.AddScoped<IToDoRepository, ToDoRepository>();
            services.AddScoped<TodoDBContext>();
        }
    }
}
