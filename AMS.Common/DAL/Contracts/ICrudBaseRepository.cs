using System.Linq.Expressions;
using AMS.Common.Data.Entities;

namespace AMS.Common.DAL.Contracts;

public interface ICrudBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<int> Add(TEntity entity);

    Task<int> AddRange(IEnumerable<TEntity> entities);

    Task<TEntity> GetById(int entityId, string? include = null);

    Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate, string? include = null);

    Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate, string? include = null);

    Task<int> Update(TEntity entity);

    Task<int> UpdateRange(IEnumerable<TEntity> entities);

    Task<int> Delete(int entityId);

    Task<int> Delete(TEntity entity);

    Task<int> DeleteRange(IEnumerable<TEntity> entities);
}