using Application.Features.Baskets.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Baskets.Rules;

public class BasketBusinessRules : BaseBusinessRules
{
    private readonly IBasketRepository _basketRepository;

    public BasketBusinessRules(IBasketRepository basketRepository)
    {
        _basketRepository = basketRepository;
    }

    public Task BasketShouldExistWhenSelected(Basket? basket)
    {
        if (basket == null)
            throw new BusinessException(BasketsBusinessMessages.BasketNotExists);
        return Task.CompletedTask;
    }

    public async Task BasketIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        Basket? basket = await _basketRepository.GetAsync(
            predicate: b => b.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BasketShouldExistWhenSelected(basket);
    }
}