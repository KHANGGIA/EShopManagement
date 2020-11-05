using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public partial class ProductTranslation
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Details { set; get; }
        public string SeoDescription { get; set; }
        public string SeoTiltle { get; set; }
        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }

        public Product Product { get; set; }
        public Language Language { get; set; }
    }
}
