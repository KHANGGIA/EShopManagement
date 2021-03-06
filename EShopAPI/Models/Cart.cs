﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
