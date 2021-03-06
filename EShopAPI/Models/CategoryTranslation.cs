﻿using System;
using System.Collections.Generic;

namespace EShopAPI.Models
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string LanguageId { get; set; }
        public string SeoAlias { get; set; }
        public Category Category { get; set; }

        public Language Language { get; set; }
    }
}
