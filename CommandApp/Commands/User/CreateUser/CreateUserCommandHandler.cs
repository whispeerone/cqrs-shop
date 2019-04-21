using System.Threading;
using System.Threading.Tasks;
using CommandApp.Commands.Repository;
using CommandApp.Entity;
using MediatR;

namespace CommandApp.Commands{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {

        private readonly UserRepository _userRepository;

        public CreateUserCommandHandler(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken){
            User newUser = new User();
 
            newUser.SetName(request.Name, request.Surname, request.Patronymic);
            newUser.SetGender(request.Gender);

            var id = _userRepository.Create(newUser);
            
            return Task.FromResult(id);
        }
    }


}