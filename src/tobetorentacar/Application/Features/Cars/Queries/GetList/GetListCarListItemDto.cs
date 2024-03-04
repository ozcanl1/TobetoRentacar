using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Cars.Queries.GetList
{
    public class GetListCarListItemDto : IDto
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public Guid Year { get; set; }
        public string Color { get; set; }

        public GetListCarListItemDto()
        {
            Model = string.Empty;
            Brand = string.Empty;
            Color = string.Empty;
        }

        public GetListCarListItemDto(Guid id, string model, string brand, Guid year, string color)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
        }
    }
}
