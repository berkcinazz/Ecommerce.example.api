using Core.Application.Responses;

namespace Application.Features.Baskets.Commands.Update;

public class UpdatedBasketResponse : IResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Amount { get; set; }
}