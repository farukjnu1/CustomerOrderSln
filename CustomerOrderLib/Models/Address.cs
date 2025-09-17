using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public AddressType AddressType { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public enum AddressType
    {
        MailingAddress = 1,
        ShippingAddress = 2
    }
}
