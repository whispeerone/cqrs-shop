using MediatR;

namespace CommandApp.Commands
{
    public interface ICommand : IRequest<int>
    {
    }
}