using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public int StaffID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public bool IsPaid { get; set; }
        public string DeliveryAddress { get; set; }
        public int OrderLineID { get; set; }
    }
}