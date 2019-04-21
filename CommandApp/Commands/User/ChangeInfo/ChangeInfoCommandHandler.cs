using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CommandApp.Commands.Repository;
using CommandApp.Events;
using MediatR;

namespace CommandApp.Commands.ChangeInfo
{
    public class ChangeInfoCommandHandler : IRequestHandler<ChangeInfoCommand, int>
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public ChangeInfoCommandHandler(UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task<int> Handle(ChangeInfoCommand request, CancellationToken cancellationToken)
        {
            var user = _userRepository.FindById(request.Id);

            user.SetGender(request.Gender);
            user.SetName(request.Name, request.Surname, request.Patronymic);
            
            _userRepository.SaveChanges();

            var @event = _mapper.Map<UserInfoChanged>(request);
            
            @event.Updated = DateTime.Now;
            @event.User = 2;
            
            
            
            return Task.FromResult(user.Id);
        }
    }
}