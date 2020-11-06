using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public DateTime DoB {get;set;}
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
