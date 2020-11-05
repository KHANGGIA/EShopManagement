using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
