using System;
using System.Collections.Generic;
using System.Text;

namespace OrderToClient.Entities.Enums
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }
        public Product Product { get; set; }

        public Double Subtotal()
        {
            return Price * Quantity;
        }
    }
}
