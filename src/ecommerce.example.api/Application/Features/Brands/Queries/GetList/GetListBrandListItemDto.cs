using Core.Application.Dtos;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Website { get; set; }
    public string Country { get; set; }
    public string AvatarFilePath { get; set; }
    public bool Approved { get; set; }
}