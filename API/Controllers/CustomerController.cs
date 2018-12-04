using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{   
    public class CustomerController : BaseController
    {
        private CustomersRepository CustomersRepository = new CustomersRepository();

        [HttpGet("All")]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return CustomersRepository.GetCustomer().ToList();
        }

        [HttpGet("{ID}", Name = nameof(GetCustomer))]
        public ActionResult<Customer> GetCustomer(int ID)
        {
            return CustomersRepository.GetCustomer().ToList().Where(x => x.Id == ID).FirstOrDefault();
        }

        [HttpPost("Register")]
        public ActionResult<Customer> Register([FromBody] Customer customer)
        {
            return CreatedAtRoute(nameof(GetCustomer),
                new { ID = customer.Id },
                customer);
        }        
    }
}