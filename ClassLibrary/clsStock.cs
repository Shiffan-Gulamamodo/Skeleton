using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public DateTime DateAdded { get; set; }
        public int SupplierID { get; set; }
        public int StockID { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public bool InStock { get; set; }
        public decimal Price { get; set; }
    }
}