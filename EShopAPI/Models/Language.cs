using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public partial class Language
    {
        public string LanguageId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
