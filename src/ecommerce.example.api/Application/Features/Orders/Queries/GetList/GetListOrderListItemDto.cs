using Core.Application.Dtos;

namespace Application.Features.Orders.Queries.GetList;

public class GetListOrderListItemDto : IDto
{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public int UserId { get; set; }
}