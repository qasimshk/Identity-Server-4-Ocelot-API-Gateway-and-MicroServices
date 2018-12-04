using System.Collections.Generic;
using System.Linq;

namespace API
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    public class CustomersRepository
    {
        private IList<Customer> CustomerEntity()
        {
            return new List<Customer> {
                new Customer{
                     Id = 1,
                     FirstName = "Donald",
                     LastName = "Duck",
                     Age = 34,
                     Gender = "Engineer"
                },
                new Customer{
                     Id = 2,
                     FirstName = "Mickey",
                     LastName = "Mouse",
                     Age = 23,
                     Gender = "Doctor"
                },
                new Customer{
                     Id = 3,
                     FirstName = "Tee",
                     LastName = "Bone",
                     Age = 36,
                     Gender = "Pilot"
                },
                new Customer{
                     Id = 4,
                     FirstName = "Dairy",
                     LastName = "Milk",
                     Age = 69,
                     Gender = "Chocolate"
                },
                new Customer{
                     Id = 5,
                     FirstName = "Santa",
                     LastName = "Xmas",
                     Age = 16,
                     Gender = "Delivary"
                },
                new Customer{
                     Id = 6,
                     FirstName = "Visual",
                     LastName = "Studio",
                     Age = 37,
                     Gender = "Tool"
                }
            };
        }

        public IEnumerable<Customer> GetCustomer()
        {
            return CustomerEntity().ToList();
        }

        public void AddCustomer(Customer customer)
        {
            var customers = CustomerEntity().ToList();
            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var customers = CustomerEntity().ToList();

            if (customers.Remove(customer))
            {
                customers.Add(customer);
            }
        }
    }
}