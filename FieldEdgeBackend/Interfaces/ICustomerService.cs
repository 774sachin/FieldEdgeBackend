using FieldEdgeBackend.Model;

namespace FieldEdgeBackend.Interfaces
{
    public interface ICustomerService
    {
        Task<Response> GetCustomers();
        Task<Response> AddCustomer(Customer customer);
        Task<Response> GetCustomerById(int customerId);
        Task<Response> UpdateCustomer(int customerId, Customer customer);
        Task<Response> DeleteCustomer(int customerId);
        Task<Response> CreateNewCustomerList();
    }
}
