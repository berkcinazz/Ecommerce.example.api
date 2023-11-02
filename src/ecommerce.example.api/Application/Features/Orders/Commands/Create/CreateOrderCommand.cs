using Application.Features.Orders.Constants;
using Application.Features.Orders.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Orders.Constants.OrdersOperationClaims;

namespace Application.Features.Orders.Commands.Create;

public class CreateOrderCommand : IRequest<CreatedOrderResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int UserId { get; set; }

    public string[] Roles => new[] { Admin, Write, OrdersOperationClaims.Create };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetOrders";

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreatedOrderResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly OrderBusinessRules _orderBusinessRules;

        public CreateOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository,
                                         OrderBusinessRules orderBusinessRules, IBasketRepository basketRepository, IOrderItemRepository orderItemRepository, IProductRepository productRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _orderBusinessRules = orderBusinessRules;
            _basketRepository = basketRepository;
            _orderItemRepository = orderItemRepository;
            _productRepository = productRepository;
        }

        public async Task<CreatedOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            var basketItems = await _basketRepository.GetListWithoutPagingAsync(s=>s.UserId == request.UserId);
            float totalAmount= 0;
            basketItems.ForEach((e) =>
            {
                var product =  _productRepository.Get(s => s.Id == e.ProductId);
                totalAmount += (float)(product.UnitPrice * e.Quantity);
            });

            Order order = new() { TotalAmount = totalAmount, UserId = request.UserId};

            var addedOrder = await _orderRepository.AddAsync(order);
            basketItems.ForEach((e) =>
            {
                var product = _productRepository.Get(s => s.Id == e.ProductId);
                OrderItem orderItem = new()
                {
                    Amount = (float)(e.Quantity * product.UnitPrice),
                    ProductId = e.ProductId,
                    Quantity = e.Quantity,
                    OrderId = addedOrder.Id
                };

                _orderItemRepository.Add(orderItem);
                _basketRepository.Delete(e);
            });

            CreatedOrderResponse response = _mapper.Map<CreatedOrderResponse>(order);
            return response;
        }
    }
}