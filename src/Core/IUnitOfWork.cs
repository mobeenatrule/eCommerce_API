namespace eCommerce.Core;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    Task<Nothing> Commit(CancellationToken cancellationToken = default);
}
