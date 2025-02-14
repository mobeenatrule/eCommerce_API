using FluentValidation;

namespace eCommerce.Application.Products.Commands;

public sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(e => e.Id).Must(e => e > 0);
    }
}
