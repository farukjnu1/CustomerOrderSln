using CustomerOrderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Repositories
{
    public class ProductRepository
    {
        // Retrieves a single customer  
        public Product Retrieve(int id)
        {
            // create an instance of the Customer Class  
            Product model = new Product(id);

            // code that retrieves the defined Customer  
            // populate the customer object and return  

            return model;
        }

        // Retrieves all customers  
        public IEnumerable<Product> Retrieve()
        {
            // code that retrieves all customers  
            return new List<Product>();
        }

        // Saves the current customer  
        public bool Save(Product model)
        {
            // code that saves the defined customer  
            return true;
        }
    }
}
