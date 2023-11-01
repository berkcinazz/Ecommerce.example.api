using Core.Application.Responses;

namespace Application.Features.Orders.Queries.GetById;

public class GetByIdOrderResponse : IResponse
{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public int UserId { get; set; }
}