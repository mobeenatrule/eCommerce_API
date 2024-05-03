using FluentValidation;

namespace eCommerce.Application.Products.Queries;

public sealed class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
{
    public GetProductByIdQueryValidator()
    {
        RuleFor(e => e.Id).Must(e => e > 0);
    }
}
