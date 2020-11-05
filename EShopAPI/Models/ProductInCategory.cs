using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class ProductInCategory
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }

        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
