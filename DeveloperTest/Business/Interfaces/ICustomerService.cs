using DeveloperTest.Models;

namespace DeveloperTest.Business.Interfaces
{
    public interface ICustomerService
    {
        CustomerModel[] GetCustomers();
        string[] GetCustomerNames();

        CustomerModel GetCustomer(int customerId);

        CustomerModel CreateCustomer(BaseCustomerModel model);
    }
}
