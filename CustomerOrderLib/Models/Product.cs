using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Models
{
    public class Product
    {
        public Product() : this(0)
        { }

        public Product(int id)
        {
            this.ProductId = id;
        }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Description) ||
                double.IsNaN(Cost))
                isValid = false;

            return isValid;
        }
    }
}
