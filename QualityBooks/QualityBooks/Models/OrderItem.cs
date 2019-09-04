using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QualityBooks.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int Quantity { get; set; }
        public decimal OrderItemPrice { get; set; }

        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
