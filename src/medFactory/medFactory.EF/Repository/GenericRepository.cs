using System.Linq.Expressions;
using medFactory.EF.Contracts;
using Microsoft.EntityFrameworkCore;

namespace medFactory.EF.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DesignTimeDbContext _context;
    private DbSet<T> DbSet { get; set; }

    public GenericRepository(DesignTimeDbContext context)
    {
        _context = context;
        DbSet = _context.CreateDbContext().Set<T>();
    }

    public async Task<T> GetById(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public IEnumerable<T>GetAll()
    {
        return DbSet.ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return DbSet.Where(expression);
    }

    public void Add(T entity)
    {
        DbSet.Add(entity);
    }

    public async Task AddRange(IEnumerable<T> entities)
    {
        await DbSet.AddRangeAsync(entities).ConfigureAwait(false);
    }

    public void Remove(T entity)
    {
        DbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        DbSet.RemoveRange(entities);
    }
}