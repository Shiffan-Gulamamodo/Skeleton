using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public decimal Price { get; set; }
        public Boolean IsAvailable { get; set; }
        public int StockID { get; set; }
        public int SupplyId { get; set; }
        public string PhoneName { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
