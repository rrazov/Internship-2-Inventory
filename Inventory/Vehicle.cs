using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Vehicle:Product
    {
        public DateTime LicenseExpireDate { get; set; }
        public int Mileage { get; set; }


        public Vehicle(Guid serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, Manufacturer manufacturer, DateTime licenseExpireDate, int mileage)
        :base(serialNumber,description,datePurchased,warrantyInMonths,priceWhenPurchased,manufacturer)
        {
            LicenseExpireDate = licenseExpireDate;
            Mileage = mileage;
        }
        
    }
}
