using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public int StockID { get; set; }
        public string ProductName { get; set; }
        public DateTime DispatchDate { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsBackOrdered { get; set; }
    }
}