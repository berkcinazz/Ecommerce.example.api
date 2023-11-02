using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;
using Application.Features.Orders.Queries.GetById;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class OrderRepository : EfRepositoryBase<Order, int, BaseDbContext>, IOrderRepository
{
    public OrderRepository(BaseDbContext context) : base(context)
    {
    }

    public List<GetByUserIdOrderResponse> GetAllOrdersByUserId(int userId)
    {
        var orders = Context.Orders.Include(i => i.Items).ThenInclude(s => s.Product).Select(p => new GetByUserIdOrderResponse()
        {
            Id = p.Id,
            Items = p.Items.Select(a=>new OrderItem()
            {
                Amount = a.Amount,
                CreatedDate = a.CreatedDate,
                DeletedDate = a.DeletedDate,
                Id = a.Id,
                OrderId = a.OrderId,
                Product = a.Product,
                ProductId = a.ProductId,
                Quantity = a.Quantity,
                UpdatedDate = a.UpdatedDate
            }).ToList(), 
            UserId = userId,
            TotalAmount = p.TotalAmount,
        });
        return orders.ToList();
    }
}