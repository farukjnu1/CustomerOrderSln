using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Models
{
    public class Order
    {
        public Order() : this(0)
        { }

        public Order(int id)
        {
            this.OrderId = id;
            Customer = new Customer();
            ShippingAddress = new Address();
            OrderItems = new List<OrderItem>();
        }

        // an object can compose other objects as its Properties  
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public double OrderPrice { get; set; }
        public Customer Customer { get; set; }
        public Address ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public class OrderItem
        {
            public int OrderItemId { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public double OrderItemPrice { get; set; }
        }
    }
}
