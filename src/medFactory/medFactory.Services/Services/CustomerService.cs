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

    public async Task AddCustomer(Customer customer)
    {
        var entity = new Customer()
        {
            CustomerId = customer.CustomerId,
            CustomerName = customer.CustomerName,
            Age = customer.Age,
            Address = customer.Address,
            AllocatedDoctor = customer.AllocatedDoctor,
            Email = customer.Email,
            Gender = customer.Gender,
            Mobile = customer.Mobile,
            Pincode = customer.Pincode,
            Orders = new List<Order>(),
            SaleInvoices = new List<SaleInvoice>()
        };
        await _unitOfWork.Customers.Add(entity);
    }
}