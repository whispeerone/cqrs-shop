using CommandApp.Enum;
using MediatR;

namespace CommandApp.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
    }
}