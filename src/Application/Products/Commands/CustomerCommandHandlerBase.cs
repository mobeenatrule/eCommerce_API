using eCommerce.Core;
using eCommerce.Core.Products;

namespace eCommerce.Application.Products.Commands;

public abstract class ProductCommandHandlerBase
{
    protected readonly IUnitOfWorkFactory _uowFactory;
    protected readonly IProductWriteRepository _repository;

    protected ProductCommandHandlerBase(
        IUnitOfWorkFactory uowFactory,
        IProductWriteRepository repository
    )
    {
        _uowFactory = uowFactory;
        _repository = repository;
    }
}
