using AutoMapper;
using Domain.Entities;
using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Queries.GetList;
using Application.Features.Brands.Commands.Create;
using Application.Features.Cars.Commands.Create;

namespace Application.Features.Cars.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, GetListCarListItemDto>().ReverseMap();
            CreateMap<Car, CreatedCarResponse>().ReverseMap();
        }
    }
}
