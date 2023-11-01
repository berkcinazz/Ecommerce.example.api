using Domain.Entities;
using Core.Persistence.Repositories;
using Application.Features.Baskets.Queries.GetList;

namespace Application.Services.Repositories;

public interface IBasketRepository : IAsyncRepository<Basket, int>, IRepository<Basket, int>
{

    List<GetListBasketListItemDto> GetByUserId(int userId);
}