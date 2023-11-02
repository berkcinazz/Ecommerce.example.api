using Domain.Entities;
using Core.Persistence.Repositories;
using Application.Features.Orders.Queries.GetById;

namespace Application.Services.Repositories;

public interface IOrderRepository : IAsyncRepository<Order, int>, IRepository<Order, int>
{

    List<GetByUserIdOrderResponse> GetAllOrdersByUserId(int userId);
}