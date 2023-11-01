using Core.Application.Dtos;

namespace Application.Features.Baskets.Queries.GetList;

public class GetListBasketListItemDto : IDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Amount { get; set; }
}