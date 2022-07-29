using medFactory.Domain.Models;

namespace medFactory.Services.Contracts;

public interface ICustomerService
{
    public IEnumerable<Customer> GetCustomers();
    public void AddCustomer(Customer customer);
}