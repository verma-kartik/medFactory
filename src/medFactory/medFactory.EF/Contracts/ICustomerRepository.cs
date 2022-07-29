using medFactory.Domain.Models;

namespace medFactory.EF.Contracts;

public interface ICustomerRepository :IGenericRepository<Customer>
{
    public void CreateCustomer(Customer customer);
}