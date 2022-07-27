using medFactory.EF.Contracts;

namespace medFactory.EF.Repository;

public class UnitOfWork :IUnitOfWork
{
    private readonly DesignTimeDbContext _context;
    private readonly Lazy<ICustomerRepository> _customerRepository;
    private readonly Lazy<IDrugRepository> _drugRepository;

    public UnitOfWork(DesignTimeDbContext context)
    {
        _context = context;
        _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(context));
        _drugRepository = new Lazy<IDrugRepository>(() => new DrugRepository(context));
    }

    public IDrugRepository Drugs => _drugRepository.Value;
    public ICustomerRepository Customers => _customerRepository.Value;

    public Task SaveChangesAsync() => _context.CreateDbContext().SaveChangesAsync();
    public void Dispose()
    {
        _context.CreateDbContext().Dispose();
    }
}