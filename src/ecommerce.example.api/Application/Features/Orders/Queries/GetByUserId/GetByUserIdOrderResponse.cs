using Core.Application.Responses;
using Domain.Entities;

namespace Application.Features.Orders.Queries.GetById;

public class GetByUserIdOrderResponse : IResponse
{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public int UserId { get; set; }

    public virtual List<OrderItem> Items { get; set; }
}