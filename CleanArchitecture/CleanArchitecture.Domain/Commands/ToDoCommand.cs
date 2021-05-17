using CleanArchitecture.Domain.Core.Commands;

namespace CleanArchitecture.Domain.Commands
{
    public abstract class ToDoCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
