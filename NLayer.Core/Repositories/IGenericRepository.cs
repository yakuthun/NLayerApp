using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        //productRepository.GetAll(x=> x.id>5).toList();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        //productRepository.where(x=>x.id>5).ToListAsync;
        IQueryable<T> Where(Expression<Func<T,bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity); //create, insert
        Task AddRangeAsync (IEnumerable<T> entities);
       void Update(T entity);
       void Remove(T entity);
       void RemoveRange(IEnumerable<T> entities);
    }
}
