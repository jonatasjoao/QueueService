using QueueService.Infra.Interfaces;

namespace QueueService.Infra.Repositories;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public TEntity GetById(long ID)
    {
        throw new NotImplementedException();
    }

    public void Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}