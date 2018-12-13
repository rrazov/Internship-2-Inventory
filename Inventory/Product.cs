using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public enum Manufacturer {
            // for Vehicle
            Toyota = 1,
            BMW = 2,
            Mercedes = 3,
            Opel = 4,
            Fiat = 5,

            // for Computers and MobilePhone
            Asus = 6,
            Acer = 7,
            Apple = 8,
            HP = 9,
            Dell = 10,
            Lenovo = 11,
            Samsung = 12,
            Sony = 13,
            HTC = 14

        }
    public class Product
    {   

        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public int WarrantyInMonths  { get; set; }
        public decimal PriceWhenPurchased { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public Product(Guid serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, Manufacturer manufacturer)
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
