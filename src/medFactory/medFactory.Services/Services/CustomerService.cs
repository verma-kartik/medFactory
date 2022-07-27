using medFactory.Domain.Models;
using medFactory.EF.Contracts;
using medFactory.Services.Contracts;

namespace medFactory.Services.Services;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;

    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public IEnumerable<Customer> GetCustomers()
    {

        var customers = _unitOfWork.Customers.GetAll();
        return customers;

    }
}