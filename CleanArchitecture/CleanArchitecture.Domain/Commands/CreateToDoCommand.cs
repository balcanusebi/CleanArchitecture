namespace CleanArchitecture.Domain.Commands
{
    public class CreateToDoCommand : ToDoCommand
    {
        public CreateToDoCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
