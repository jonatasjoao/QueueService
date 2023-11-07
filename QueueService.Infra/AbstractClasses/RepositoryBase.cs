namespace QueueService.Infra.AbstractClasses;

public abstract class RepositoryBase<TEntity> : I
{
    protected readonly AppDbContext Db;
    protected readonly DbSet<TEntity> DbSet;

    public Repository(AppDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public virtual TEntity GetById(Int64 ID)
    {
        return DbSet.Find(ID);
    }

    public virtual void Insert(TEntity entity)
    {
        DbSet.Add(entity);
    }

    public virtual void Update(TEntity entity)
    {
        DbSet.Update(entity);
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return DbSet;
    }
    

    public void Dispose()
    {
        Db.Dispose();
        GC.SuppressFinalize(this);
    }
}