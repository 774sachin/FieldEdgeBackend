using FieldEdgeBackend.Interfaces;
using FieldEdgeBackend.Model;
using Microsoft.AspNetCore.Mvc;

namespace FieldEdgeBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _customerService;

        public CustomerController(ICustomerRepository customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        [Route("customerlist")]
        public async Task<ActionResult<Response>> Index()
        {
            return await _customerService.GetCustomers();
        }

        [HttpGet]
        [Route("createcustomerlist")]
        public async Task<ActionResult<Response>> CreateNewCustomerList()
        {
            return await _customerService.CreateNewCustomerList();
        }

        [HttpGet]
        [Route("customerbyid")]
        public async Task<ActionResult<Response>> GetCustomerById(int id)
        {
            return await _customerService.GetCustomerById(id);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult<Response>> DeleteCustomer(int id)
        {
            return await _customerService.DeleteCustomer(id);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Response>> AddCustomer(Customer model)
        {
            return await _customerService.AddCustomer(model);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Response>> UpdateCustomer(int id, Customer model)
        {
            return await _customerService.UpdateCustomer(id,model);
        }
    }
}
