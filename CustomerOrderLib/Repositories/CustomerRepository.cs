using CustomerOrderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Repositories
{
    public class CustomerRepository
    {
        // Retrieves a single customer  
        public Customer Retrieve(int id)
        {
            // create an instance of the Customer Class  
            Customer customer = new Customer(id);

            // code that retrieves the defined Customer  
            // populate the customer object and return  

            return customer;
        }

        // Retrieves all customers  
        public IEnumerable<Customer> Retrieve()
        {
            // code that retrieves all customers  
            return new List<Customer>();
        }

        // Saves the current customer  
        public bool Save(Customer model)
        {
            // code that saves the defined customer  
            return true;
        }
    }
}
