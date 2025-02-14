namespace eCommerce.Core;

public interface IWriteRepository<in T>
    where T : BaseEntity
{
    public Task<Nothing> Create(T entity, IUnitOfWork uow);
    public Task<Nothing> Update(T entity, IUnitOfWork uow);
    public Task<bool> Delete(int id, IUnitOfWork uow);
}
