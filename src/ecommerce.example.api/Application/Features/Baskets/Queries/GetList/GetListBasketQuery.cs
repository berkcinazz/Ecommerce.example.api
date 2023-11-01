using Application.Features.Baskets.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using static Application.Features.Baskets.Constants.BasketsOperationClaims;

namespace Application.Features.Baskets.Queries.GetList;

public class GetListBasketQuery : IRequest<GetListResponse<GetListBasketListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public bool BypassCache { get; }
    public string CacheKey => $"GetListBaskets({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetBaskets";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBasketQueryHandler : IRequestHandler<GetListBasketQuery, GetListResponse<GetListBasketListItemDto>>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public GetListBasketQueryHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBasketListItemDto>> Handle(GetListBasketQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Basket> baskets = await _basketRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBasketListItemDto> response = _mapper.Map<GetListResponse<GetListBasketListItemDto>>(baskets);
            return response;
        }
    }
}