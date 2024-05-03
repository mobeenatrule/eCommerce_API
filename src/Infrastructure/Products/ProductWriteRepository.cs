using eCommerce.Core.Products;
using eCommerce.Infrastructure.Persistence;

namespace eCommerce.Infrastructure.Products;

public class ProductWriteRepository : WriteRepositoryBase<Product>, IProductWriteRepository
{
    public ProductWriteRepository()
        : base() { }
}
