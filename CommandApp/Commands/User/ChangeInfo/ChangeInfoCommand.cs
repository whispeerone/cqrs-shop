using CommandApp.Enum;
using MediatR;

namespace CommandApp.Commands.ChangeInfo
{
    public class ChangeInfoCommand : ICommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public int Id { get; set; }
    }
}