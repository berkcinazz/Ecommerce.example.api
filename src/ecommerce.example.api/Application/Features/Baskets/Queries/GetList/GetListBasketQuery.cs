using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Baskets.Constants.BasketsOperationClaims;

namespace Application.Features.Baskets.Queries.GetList;

public class GetListBasketQuery : IRequest<List<GetListBasketListItemDto>>, ISecuredRequest
{
    public int UserId { get; set; }
    public string[] Roles => new[] { Admin, Read };

    public bool BypassCache { get; }

    public class GetListBasketQueryHandler : IRequestHandler<GetListBasketQuery, List<GetListBasketListItemDto>>
    {
        private readonly IBasketRepository _basketRepository;

        public GetListBasketQueryHandler(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public async Task<List<GetListBasketListItemDto>> Handle(GetListBasketQuery request, CancellationToken cancellationToken)
        {
            var baskets = _basketRepository.GetByUserId(request.UserId);
            return baskets;
        }
    }
}