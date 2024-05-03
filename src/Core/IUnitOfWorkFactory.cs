namespace eCommerce.Core;

public interface IUnitOfWorkFactory
{
    Task<IUnitOfWork> Create(CancellationToken cancellationToken = default);
}
