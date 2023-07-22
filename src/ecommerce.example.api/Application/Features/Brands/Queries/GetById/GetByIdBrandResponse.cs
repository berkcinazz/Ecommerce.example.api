using Core.Application.Responses;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandResponse : IResponse
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