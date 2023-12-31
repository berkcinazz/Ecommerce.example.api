using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using System.Collections.Generic;
using Application.Services.Brands;

namespace Application.Features.Products.Queries.GetList;

public class GetListProductQuery : IRequest<GetListResponse<GetListProductListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListProducts({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetProducts";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, GetListResponse<GetListProductListItemDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IBrandsService _brandsService;
        private readonly IMapper _mapper;

        public GetListProductQueryHandler(IProductRepository productRepository, IMapper mapper, IBrandsService brandsService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _brandsService = brandsService;
        }

        public async Task<GetListResponse<GetListProductListItemDto>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Product> products = await _productRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );
            GetListResponse<GetListProductListItemDto> response = _mapper.Map<GetListResponse<GetListProductListItemDto>>(products);

            foreach (var item in response.Items)
            {
                item.Brand = await _brandsService.GetAsync(i => i.Id == item.BrandId);
            }
            return response;
        }
    }
}