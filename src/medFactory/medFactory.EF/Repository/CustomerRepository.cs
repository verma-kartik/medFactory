using medFactory.Domain.Models;
using medFactory.EF.Contracts;

namespace medFactory.EF.Repository;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(DesignTimeDbContext context) : base(context)
    {
    }
}