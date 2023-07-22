using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Brands.Rules;

public class BrandBusinessRules : BaseBusinessRules
{
    private readonly IBrandRepository _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandShouldntExistWhenCreated(string name, CancellationToken cancellationToken)
    {
        var selectedBrand = await _brandRepository.GetAsync(s => s.Name == name, cancellationToken: cancellationToken);
        if (selectedBrand != null)
            throw new BusinessException(BrandsBusinessMessages.BrandAlreadyExists);
    }
    public async Task BrandIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        var selectedBrand = await _brandRepository.GetAsync(s => s.Id == id, cancellationToken: cancellationToken);
        if (selectedBrand == null)
            throw new BusinessException(BrandsBusinessMessages.BrandNotExists);
    }
    public async Task BrandShouldExistWhenSelected(Brand brand, CancellationToken cancellationToken)
    {
        if (brand == null)
            throw new BusinessException(BrandsBusinessMessages.BrandNotExists);
        var selectedBrand = await _brandRepository.GetAsync(s => s.Name == brand.Name, cancellationToken: cancellationToken);
        if (selectedBrand == null)
            throw new BusinessException(BrandsBusinessMessages.BrandAlreadyExists);
    }
}