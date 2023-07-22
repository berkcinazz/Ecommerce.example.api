using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.ProductCode).NotEmpty();
        RuleFor(c => c.UnitPrice).NotEmpty();
        RuleFor(c => c.UnitsInStock).NotEmpty();
        RuleFor(c => c.QuantityPerUnit).NotEmpty();
        RuleFor(c => c.CommonCode).NotEmpty();
        RuleFor(c => c.OnSale).NotEmpty();
        RuleFor(c => c.ShippingCost).NotEmpty();
        RuleFor(c => c.BrandId).NotEmpty();
    }
}