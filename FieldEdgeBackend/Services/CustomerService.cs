using FieldEdgeBackend.Interfaces;
using FieldEdgeBackend.Model;

namespace FieldEdgeBackend.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public async Task<Response> AddCustomer(Customer customer)
        {
            return await _customerRepo.AddCustomer(customer);
        }

        public Task<Response> CreateNewCustomerList()
        {
            return _customerRepo.CreateNewCustomerList();
        }

        public Task<Response> DeleteCustomer(int customerId)
        {
           return (_customerRepo.DeleteCustomer(customerId));
        }

        public Task<Response> GetCustomerById(int customerId)
        {
           return (_customerRepo.GetCustomerById(customerId));
        }

        public Task<Response> GetCustomers()
        {
            return (_customerRepo.GetCustomers());
        }

        public Task<Response> UpdateCustomer(int customerId, Customer customer)
        {
            return (_customerRepo.UpdateCustomer(customerId,customer));
        }
    }
}
