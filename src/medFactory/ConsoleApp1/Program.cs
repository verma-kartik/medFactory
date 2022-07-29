// See https://aka.ms/new-console-template for more information

using medFactory.Domain.Models;
using medFactory.EF;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

namespace ConsoleApp1;

public static class Program
{
    public static void Main(string[] args)
    {
        IServiceManager service = new ServiceManager(new UnitOfWork(new DesignTimeDbContext()));

        var customer = new Customer
        {
            Address = "Rohini",
            Age = 12,
            CustomerId = 2,
            Email = "idk@gmail.com",
            Gender = "male",
            CustomerName = "Aditya",
            Mobile = 9310347292,
            Pincode = 112233,
            AllocatedDoctor = "Mr. Pratt"
        };
        
        service.CustomerService.AddCustomer(customer);

        var list = service.CustomerService.GetCustomers();
        Console.WriteLine(list.Count());
        



    }
}