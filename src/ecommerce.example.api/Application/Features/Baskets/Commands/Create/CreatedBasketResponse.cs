using Core.Application.Responses;

namespace Application.Features.Baskets.Commands.Create;

public class CreatedBasketResponse : IResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Amount { get; set; }
}