using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool IsCustomerAccountActive { get; set; }
        public DateTime CustomerAccountCreatedAt { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerAddress { get; set; }
    }
}