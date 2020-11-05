using SharedObject.Commons;
using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowHome { get; set; }
        public Guid? ParentId { get; set; }
        public Status Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }


    }
}
