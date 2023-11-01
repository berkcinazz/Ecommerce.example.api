using Application.Features.OrderItems.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using static Application.Features.OrderItems.Constants.OrderItemsOperationClaims;

namespace Application.Features.OrderItems.Queries.GetList;

public class GetListOrderItemQuery : IRequest<GetListResponse<GetListOrderItemListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public bool BypassCache { get; }
    public string CacheKey => $"GetListOrderItems({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetOrderItems";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListOrderItemQueryHandler : IRequestHandler<GetListOrderItemQuery, GetListResponse<GetListOrderItemListItemDto>>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public GetListOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListOrderItemListItemDto>> Handle(GetListOrderItemQuery request, CancellationToken cancellationToken)
        {
            IPaginate<OrderItem> orderItems = await _orderItemRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListOrderItemListItemDto> response = _mapper.Map<GetListResponse<GetListOrderItemListItemDto>>(orderItems);
            return response;
        }
    }
}