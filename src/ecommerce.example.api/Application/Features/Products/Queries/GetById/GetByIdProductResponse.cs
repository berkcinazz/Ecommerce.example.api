using Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ProductCode { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
    public string CommonCode { get; set; }
    public bool OnSale { get; set; }
    public decimal ShippingCost { get; set; }
    public int BrandId { get; set; }
}