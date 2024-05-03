using HumbleMediator;
using eCommerce.Core.Products;

namespace eCommerce.Application.Products.Commands;

public record UpdateProductCommand(int Id, Product Product) : ICommand<Product>;
