using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Security.Hashing;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Commands.Update
{
    public class UpdateCarCommand : IRequest<UpdatedCarResponse>
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        

        public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, UpdatedCarResponse>
        {
            private readonly ICarRepository _carRepository;
            private readonly IMapper _mapper;

            public UpdateCarCommandHandler(ICarRepository carRepository, IMapper mapper)
            {
                _carRepository = carRepository;
                _mapper = mapper;
            }

            public async Task<UpdatedCarResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
            {
                
                Car car = await _carRepository.GetAsync(c => c.Id == request.Id);
                
                if (car == null)
                {
                  
                    throw new Exception("Güncellenmek istenen araç bulunamadı.");
                }

                
                car.Model = request.Model;
                

                await _carRepository.UpdateAsync(car);

               
                UpdatedCarResponse response = _mapper.Map<UpdatedCarResponse>(car);
                return response;
            }
        }
    }
}
