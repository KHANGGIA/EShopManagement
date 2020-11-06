using SharedObject.Commons;
using System;


namespace EShopAPI.Models
{
    public class Transaction
    {
        public Guid Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransaction { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
