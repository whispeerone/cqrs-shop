using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CommandApp.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>

    {
        public Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(666);
        }
    }


}