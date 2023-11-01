using Core.Application.Dtos;

namespace Application.Features.OrderItems.Queries.GetList;

public class GetListOrderItemListItemDto : IDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Amount { get; set; }
    public int OrderId { get; set; }
}