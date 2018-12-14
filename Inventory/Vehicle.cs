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

        public void PrintVehicle()
        {
            
            decimal price = PriceWhenPurchased;
            decimal price20PercentLess = price - (price * (decimal)0.2);
            for (int i = 0; i < Mileage; i += 20000)
            {
                if (Mileage < 20000)
                {
                    break;
                }
                else
                {
                    price = (price - (price * (decimal)0.1));
                    if (price <= price20PercentLess)
                    {
                        break;
                    }
                }
                
            }
            var diffPrice = PriceWhenPurchased - price;

            Console.WriteLine("\n----- Vehicle -----");
            Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n License expirate date: {LicenseExpireDate}\n Mileage: {Mileage}");
            Console.WriteLine($" Price now: {Decimal.Round(price)} \n DiffPrice: {Decimal.Round(diffPrice)}");
        }
    }
}
