using Core.Application.Responses;

namespace Application.Features.Orders.Commands.Create;

public class CreatedOrderResponse : IResponse
{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public int UserId { get; set; }
}