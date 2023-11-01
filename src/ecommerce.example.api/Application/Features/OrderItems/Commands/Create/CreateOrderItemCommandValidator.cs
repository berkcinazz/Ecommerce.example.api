using FluentValidation;

namespace Application.Features.OrderItems.Commands.Create;

public class CreateOrderItemCommandValidator : AbstractValidator<CreateOrderItemCommand>
{
    public CreateOrderItemCommandValidator()
    {
        RuleFor(c => c.ProductId).NotEmpty();
        RuleFor(c => c.Quantity).NotEmpty();
        RuleFor(c => c.Amount).NotEmpty();
        RuleFor(c => c.OrderId).NotEmpty();
    }
}