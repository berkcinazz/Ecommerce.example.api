using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BasketRepository : EfRepositoryBase<Basket, int, BaseDbContext>, IBasketRepository
{
    public BasketRepository(BaseDbContext context) : base(context)
    {
    }
}