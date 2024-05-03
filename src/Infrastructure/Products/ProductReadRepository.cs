using eCommerce.Core.Products;
using eCommerce.Infrastructure.Persistence;

namespace eCommerce.Infrastructure.Products;

public class ProductReadRepository : ReadRepositoryBase<Product>, IProductReadRepository
{
    public ProductReadRepository(AppDbContext db)
        : base(db) { }
}
