using HumbleMediator;
using eCommerce.Core.Products;

namespace eCommerce.Application.Products.Queries;

public sealed record GetProductByIdQuery(int Id) : IQuery<Product?>;
