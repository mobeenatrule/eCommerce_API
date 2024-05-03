using FluentAssertions;
using NSubstitute;
using eCommerce.Application.Products.Queries;
using eCommerce.Core.Products;
using Xunit;

namespace eCommerce.UnitTests.Products.GetProductByIdQueryHandler;

public class HandleTests
{
    [Fact]
    public async Task WithValidRequestShouldCallRepository()
    {
        // Arrange
        var expected = new Product(1);
        var mock = Substitute.For<IProductReadRepository>();
        mock.GetById(default).ReturnsForAnyArgs(expected);

        var sut = new Application.Products.Queries.GetProductByIdQueryHandler(mock);

        // Act
        var result = await sut.Handle(new GetProductByIdQuery(1));

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
