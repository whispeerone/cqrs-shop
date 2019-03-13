using System.Threading.Tasks;
using CommandApp.Commands;
using CommandApp.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandApp.Controllers
{
    [Route("/api/[controller]")]
    public class UserController : Controller
    {

        private readonly UserService _userService;
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<int> Create([FromBody] CreateUserCommand command)
        {
            return await _mediator.Send(command);
        } 
    }
}