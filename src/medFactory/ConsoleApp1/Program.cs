// See https://aka.ms/new-console-template for more information

using medFactory.Domain.Models;
using medFactory.EF;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

namespace ConsoleApp1;

public class Program
{
    static async Task Main(string[] args)
    {
        IServiceManager service = new ServiceManager(new UnitOfWork(new DesignTimeDbContext()));

        var customer = new Customer();

        customer.Address = "Rohini";
        customer.Age = 12;
        customer.CustomerId = 2;
        customer.Email = "idk@gmail.com";
        customer.Gender = "male";
        customer.CustomerName = "Aditya";
        customer.Mobile = 9310347292;
        customer.Pincode = 112233;
        customer.AllocatedDoctor = "Mr. Pratt";

        var entity = customer;

        await service.CustomerService.AddCustomer(entity);

        var list = service.CustomerService.GetCustomers();

        Console.WriteLine(list.Count());
    }
}