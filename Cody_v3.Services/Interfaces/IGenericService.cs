using Cody_v3.Repositories.Paging;
using System.Linq.Expressions;

namespace Cody_v3.Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid Id);
        Task<T> GetById(string Id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(Guid Id);
        Task<int> Delete(string Id);
        Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        IQueryable<T> GetByConditionQueryable(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        Task<PageResult<T>> GetWithPaging(int page, int pageSize, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        Task<int> Insert(List<T> entities);
        Task<int> Update(List<T> entities);
        Task<int> Delete(Expression<Func<T, bool>> filter = null);
        Task<int> SoftDelete(Guid Id);
        Task<int> SoftDelete(string Id);

        Task<List<T>> ExecProcDataAsync(string storedProcedureName, object parameter);
        Task<int> ExecProcNonqueryAsync(string storedProcedureName, object parameter);
    }
}
