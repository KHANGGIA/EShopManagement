using SharedObject.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class BlogCategory
    {
        public Guid BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public int? Amount { get; set; }
        public Status Status { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
