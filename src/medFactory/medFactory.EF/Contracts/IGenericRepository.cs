using System.Linq.Expressions;

namespace medFactory.EF.Contracts;

public interface IGenericRepository<T> where  T :class
{
    Task<T> GetById(int id);
    IEnumerable<T> GetAll();

    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    void Add(T entity);
    Task AddRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}