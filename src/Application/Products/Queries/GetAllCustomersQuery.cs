using HumbleMediator;
using eCommerce.Core;
using eCommerce.Core.Products;

namespace eCommerce.Application.Products.Queries;

public sealed record GetAllProductsQuery() : IQuery<PaginatedResponse<Product>>
{
    public int PageSize { get; set; }
    public int Page { get; set; }


}
