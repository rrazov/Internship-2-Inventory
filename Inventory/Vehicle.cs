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

        public void PrintBySerialNumber()
        {
            Console.WriteLine("----- Vehicle -----");
            Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n License expirate date: {LicenseExpireDate}\n Mileage: {Mileage}\n");
        }
        
    }
}
