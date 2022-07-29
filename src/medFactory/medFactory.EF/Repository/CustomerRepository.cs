using medFactory.Domain.Models;
using medFactory.EF.Contracts;

namespace medFactory.EF.Repository;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(DesignTimeDbContext context) : base(context)
    {
    }

    public void CreateCustomer(Customer customer)
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
            Pincode = customer.Pincode
        }; 
        
        Add(entity);
    }
}