using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CommandApp.Infrastructure
{
    public class CommandLogger<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine("WOOOOW");
            return next();
        }
    }
}