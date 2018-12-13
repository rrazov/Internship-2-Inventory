using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Product
    {
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public int WarrantyInMonths  { get; set; }
        public decimal PriceWhenPurchased { get; set; }
        public string Manufacturer { get; set; }

        public Product(int serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            DatePurchased = datePurchased;
            WarrantyInMonths = warrantyInMonths;
            PriceWhenPurchased = priceWhenPurchased;
            Manufacturer = manufacturer;


        }
    
    }
    
}