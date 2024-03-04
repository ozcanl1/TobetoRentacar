using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Commands.Delete;

public class DeleteCarCommand : IRequest<Unit>
{
    public Guid CarId { get; set; }
    public Guid Id { get; set; }

    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, Unit>
    {
        

        public DeleteCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            
        }

        public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            
            return Unit.Value;
        }
  
}
}