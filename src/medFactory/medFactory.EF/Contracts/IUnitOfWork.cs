namespace medFactory.EF.Contracts;

public interface IUnitOfWork : IDisposable
{
    IDrugRepository Drugs { get; }
    ICustomerRepository Customers { get; }

    Task SaveChangesAsync();
}