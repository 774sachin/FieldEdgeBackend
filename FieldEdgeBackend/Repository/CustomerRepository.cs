using FieldEdgeBackend.Helper;
using FieldEdgeBackend.Interfaces;
using FieldEdgeBackend.Model;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Nodes;
using System.Text;

namespace FieldEdgeBackend.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public CustomerRepository(IHttpClientFactory HttpClientFactory)
        {
            _httpClientFactory = HttpClientFactory;
        }
        public async Task<Response> AddCustomer(Customer customer)
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var data = JsonConvert.SerializeObject(customer);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"Customer/", content);
            var customers = JsonConvert.DeserializeObject<List<Customer>>(await response.Content.ReadAsStringAsync()) ?? Enumerable.Empty<Customer>();
            return BuildResponse.DoThis(customers, response.IsSuccessStatusCode == true ? "customer added successfully" : "failed add customer", response.StatusCode);
        }

        public async Task<Response> CreateNewCustomerList()
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var response = await httpClient.GetAsync($"CreateCustomerList/");
            return BuildResponse.DoThis(null, response.IsSuccessStatusCode == true ? "recreated successfull." : "failed to create customer list", response.StatusCode);
        }

        public async Task<Response> DeleteCustomer(int customerId)
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var response = await httpClient.DeleteAsync($"Customer/" + customerId);
            return BuildResponse.DoThis(null, response.IsSuccessStatusCode == true? "customer deleted" : "customer faield to delete", response.StatusCode);
        }

        public async Task<Response> GetCustomerById(int customerId)
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var response = await httpClient.GetAsync($"Customer/"+customerId);
            var customers = JsonConvert.DeserializeObject<Customer>(await response.Content.ReadAsStringAsync()) ?? null ;
            return BuildResponse.DoThis(customers, response.IsSuccessStatusCode == true ? "customer found" : "customer does not exist", response.StatusCode);
        }

        public async Task<Response> GetCustomers()
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var response = await httpClient.GetAsync($"Customers");
            var customers = JsonConvert.DeserializeObject<List<Customer>>(await response.Content.ReadAsStringAsync()) ?? Enumerable.Empty<Customer>();
            return BuildResponse.DoThis(customers, response.IsSuccessStatusCode == true ? "successful":"failed", response.StatusCode);
        }

        public async Task<Response> UpdateCustomer(int customerId, Customer customer)
        {
            var httpClient = _httpClientFactory.CreateClient("FieldEdgeWebDeveloper");
            var  data = JsonConvert.SerializeObject(customer);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"Customer/"+customerId, content);
            var customers = JsonConvert.DeserializeObject<List<Customer>>(await response.Content.ReadAsStringAsync()) ?? Enumerable.Empty<Customer>();
            return BuildResponse.DoThis(customers, response.IsSuccessStatusCode == true ? "customer updated successfully" : "failed update customer", response.StatusCode);
        }
    
    }
}
