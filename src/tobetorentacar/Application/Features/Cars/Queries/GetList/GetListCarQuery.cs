using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetList
{
    public class GetListCarQuery : IRequest<GetListResponse<GetListCarListItemDto>>
    {
        public PageRequest PageRequest { get; set; }

        public class GetListCarQueryHandler : IRequestHandler<GetListCarQuery, GetListResponse<GetListCarListItemDto>>
        {
            private readonly ICarRepository _carRepository;
            private readonly IMapper _mapper;

            public GetListCarQueryHandler(ICarRepository carRepository, IMapper mapper)
            {
                _carRepository = carRepository;
                _mapper = mapper;
            }

            public async Task<GetListResponse<GetListCarListItemDto>> Handle(GetListCarQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Car> cars = await _carRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);

                GetListResponse<GetListCarListItemDto> response = _mapper.Map<GetListResponse<GetListCarListItemDto>>(cars);

                return response;
            }
        }
    }
}
