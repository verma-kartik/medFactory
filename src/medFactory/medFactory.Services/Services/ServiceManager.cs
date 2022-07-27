using medFactory.EF.Repository;
using medFactory.Services.Contracts;

namespace medFactory.Services.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICustomerService> _customerService;

    public ServiceManager(UnitOfWork unitOfWork)
    {
        _customerService = new Lazy<ICustomerService>(
            () => new CustomerService(unitOfWork));
    }
    
    public ICustomerService CustomerService => _customerService.Value;
}