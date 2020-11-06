using SharedObject.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class BlogPost
    {
        public Guid BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreated { get; set; }
        public Status Status { get; set; }
        public string UserId { get; set; }
        public string Image { get; set; }
        public Guid? BlogCategoryId { get; set; }

        public AppUser AppUser { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }
}
