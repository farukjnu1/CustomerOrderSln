using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Models
{
    public class Book : Product
    {
        public string Authod { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; } //International Standard Book Number
    }
}
