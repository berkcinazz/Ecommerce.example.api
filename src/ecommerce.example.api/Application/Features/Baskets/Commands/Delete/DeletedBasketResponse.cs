using Core.Application.Responses;

namespace Application.Features.Baskets.Commands.Delete;

public class DeletedBasketResponse : IResponse
{
    public int Id { get; set; }
}