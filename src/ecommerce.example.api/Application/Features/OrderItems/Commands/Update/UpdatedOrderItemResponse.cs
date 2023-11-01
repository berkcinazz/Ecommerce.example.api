using Core.Application.Responses;

namespace Application.Features.OrderItems.Commands.Update;

public class UpdatedOrderItemResponse : IResponse
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Amount { get; set; }
    public int OrderId { get; set; }
}