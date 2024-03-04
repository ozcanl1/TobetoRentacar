using NArchitecture.Core.Application.Responses;

namespace Application.Features.Cars.Commands.Create;

    public class CreatedCarResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public Guid Year { get; set; }
        public string Color { get; set; }

        public CreatedCarResponse()
        {
            Model = string.Empty;
            Brand = string.Empty;
            Color = string.Empty;
        }

        public CreatedCarResponse(Guid id, string model, string brand, Guid year, string color)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
        }
    }

