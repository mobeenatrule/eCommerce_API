using HumbleMediator;
using eCommerce.Core.Products;

namespace eCommerce.Application.Products.Commands;

public record DeleteProductCommand(int Id) : ICommand<StatusCodeResponse>;
