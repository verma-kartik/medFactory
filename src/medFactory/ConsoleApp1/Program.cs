// See https://aka.ms/new-console-template for more information

using medFactory.EF;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

namespace ConsoleApp1;

public class Program
{
    static async Task Main(string[] args)
    {
        IServiceManager _service = new ServiceManager(new UnitOfWork(new DesignTimeDbContext()));

        var customers = _service.CustomerService.GetCustomers();

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.CustomerName);
        }
        
    }
}