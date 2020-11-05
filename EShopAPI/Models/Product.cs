using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int StockQuantity { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
