using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Application.Features.Baskets.Queries.GetList;

namespace Persistence.Repositories;

public class BasketRepository : EfRepositoryBase<Basket, int, BaseDbContext>, IBasketRepository
{
    public BasketRepository(BaseDbContext context) : base(context)
    {
    }

    public List<GetListBasketListItemDto> GetByUserId(int userId)
    {
        var baskets = Context.Baskets.Include(c => c.Product).Where(a=>a.UserId == userId).Select(p=> new GetListBasketListItemDto()
        {
            UserId = userId,
            Id = p.Id,
            Product = p.Product,
            ProductId = p.ProductId,
            Quantity = p.Quantity
        }).ToList();
        return baskets;
    }
}