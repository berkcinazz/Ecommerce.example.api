using Core.Application.Responses;

namespace Application.Features.Baskets.Queries.GetById;

public class GetByIdBasketResponse : IResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}