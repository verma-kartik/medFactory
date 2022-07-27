namespace medFactory.Services.Contracts;

public interface IServiceManager
{
    ICustomerService CustomerService { get; }
}