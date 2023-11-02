using Application.Features.Orders.Constants;
using Application.Features.Orders.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Orders.Constants.OrdersOperationClaims;

namespace Application.Features.Orders.Queries.GetById;

public class GetByUserIdOrderQuery : IRequest<List<GetByUserIdOrderResponse>>, ISecuredRequest
{
    public int UserId { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public class GetByIdOrderQueryHandler : IRequestHandler<GetByUserIdOrderQuery, List<GetByUserIdOrderResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;

        public GetByIdOrderQueryHandler(IMapper mapper, IOrderRepository orderRepository, OrderBusinessRules orderBusinessRules)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<List<GetByUserIdOrderResponse>> Handle(GetByUserIdOrderQuery request, CancellationToken cancellationToken)
        {
            var order = _orderRepository.GetAllOrdersByUserId(request.UserId);
            return order;
        }
    }
}