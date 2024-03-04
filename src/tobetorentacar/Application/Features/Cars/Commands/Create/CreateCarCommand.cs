using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Constants;
using Application.Features.Cars.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using System.Threading;
using System.Threading.Tasks;


namespace Application.Features.Cars.Commands.Create
{
    public class CreateCarCommand : IRequest<CreatedCarResponse>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }

        public CreateCarCommand()
        {
            Make = string.Empty;
            Model = string.Empty;
            Color = string.Empty;
        }

        public CreateCarCommand(string make, string model, int year, string color, decimal price, string brand)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Price = price;
            Brand = brand;
        }
    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, CreatedCarResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CreateCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCarResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            Car car = _mapper.Map<Car>(request);

               Car createdCar = await _carRepository.AddAsync(car);

            
            CreatedCarResponse response = _mapper.Map<CreatedCarResponse>(createdCar);
            return response;
        }
    }
}
