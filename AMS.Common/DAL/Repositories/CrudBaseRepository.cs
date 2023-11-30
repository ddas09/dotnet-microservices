using AMS.Common.Data;
using System.Linq.Expressions;
using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.Common.DAL.Repositories;

public abstract class CrudBaseRepository<TEntity> : ICrudBaseRepository<TEntity> where TEntity : BaseEntity
{
    private readonly BaseDBContext _dbContext;
    private readonly DbSet<TEntity> _entities;

    public CrudBaseRepository(BaseDBContext dbContext)
    {
        _dbContext = dbContext;
        _entities = _dbContext.Set<TEntity>();
    }

    public virtual async Task<int> Add(TEntity entity)
    {
        await _entities.AddAsync(entity);
        await this.SaveChanges();
        return entity.Id;
    }

    public virtual async Task<int> AddRange(IEnumerable<TEntity> entities)
    {
        _entities.AddRange(entities);
        return await this.SaveChanges();
    }

    public virtual async Task<int> Delete(int entityId)
    {
        var entity = _entities.FirstOrDefault(entity => entity.Id == entityId)
            ?? throw new KeyNotFoundException($"Entity with this id - {entityId} not found.");

        _entities.Remove(entity);
        return await this.SaveChanges();
    }

    public virtual async Task<int> Delete(TEntity entity)
    {
        _entities.Remove(entity);
        return await this.SaveChanges();
    }

    public virtual async Task<int> DeleteRange(IEnumerable<TEntity> entities)
    {
        _entities.RemoveRange(entities);
        return await this.SaveChanges();
    }

    public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate, string? include = null)
    {
        IQueryable<TEntity> query = _entities;

        if (!string.IsNullOrEmpty(include))
        {
            query = query.Include(include);
        }

        var entity = await query.FirstOrDefaultAsync(predicate);
        return entity ?? throw new KeyNotFoundException("Entity with this match not found.");
    }

    public virtual async Task<TEntity> GetById(int entityId, string? include = null)
    {
        return await this.Get(predicate: entity => entity.Id == entityId);
    }

    public virtual async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate, string? include = null)
    {
        IQueryable<TEntity> query = _entities;

        if (!string.IsNullOrEmpty(include))
        {
            query = query.Include(include);
        }

        return await query.Where(predicate).ToListAsync();
    }

    public virtual async Task<int> Update(TEntity entity)
    {
        _entities.Update(entity);
        return await this.SaveChanges();
    }

    public virtual async Task<int> UpdateRange(IEnumerable<TEntity> entities)
    {
        _entities.UpdateRange(entities);
        return await this.SaveChanges();
    }

    protected async Task<int> SaveChanges()
    {
        return await _dbContext.SaveChangesAsync();
    }
}