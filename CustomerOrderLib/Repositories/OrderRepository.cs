using CustomerOrderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Repositories
{
    public class OrderRepository
    {
        // Retrieves a single customer  
        public Order Retrieve(int id)
        {
            // create an instance of the Customer Class  
            Order model = new Order(id);

            // code that retrieves the defined Customer  
            // populate the customer object and return  

            return model;
        }

        // Retrieves all customers  
        public IEnumerable<Order> Retrieve()
        {
            // code that retrieves all customers  
            return new List<Order>();
        }

        // Saves the current customer  
        public bool Save(Order model)
        {
            // code that saves the defined customer  
            return true;
        }
    }
}
