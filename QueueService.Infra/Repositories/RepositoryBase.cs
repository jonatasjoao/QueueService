using Microsoft.EntityFrameworkCore;
using QueueService.Infra.Interfaces;

namespace QueueService.Infra.Repositories;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    protected readonly DbContext Db;
    protected readonly DbSet<TEntity> DbSet;

    public RepositoryBase(DbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }
    public void Dispose()
    {
        Db.Dispose();
        GC.SuppressFinalize(this);
    }

    public TEntity GetById(long ID)
    {
        return DbSet.Find(ID);
    }

    public void Insert(TEntity entity)
    {
        DbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        DbSet.Update(entity);
    }

    public IQueryable<TEntity> GetAll()
    {
        return DbSet;
    }
}