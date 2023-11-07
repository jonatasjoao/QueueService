namespace QueueService.Infra.Interfaces;

public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
{
    
    TEntity GetById(Int64 ID);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    IQueryable<TEntity> GetAll();
}