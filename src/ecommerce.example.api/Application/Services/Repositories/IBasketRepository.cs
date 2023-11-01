using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IBasketRepository : IAsyncRepository<Basket, int>, IRepository<Basket, int>
{
}