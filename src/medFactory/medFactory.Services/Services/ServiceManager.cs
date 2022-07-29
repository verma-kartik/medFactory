using medFactory.EF.Repository;
using medFactory.Services.Contracts;

namespace medFactory.Services.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICustomerService> _customerService;
    private readonly Lazy<IDrugService> _drugService;

    public ServiceManager(UnitOfWork unitOfWork)
    {
        _customerService = new Lazy<ICustomerService>(
            () => new CustomerService(unitOfWork));

        _drugService = new Lazy<IDrugService>(
            () => new DrugService(unitOfWork));
    }
    
    public ICustomerService CustomerService => _customerService.Value;
    public IDrugService DrugService => _drugService.Value;
}