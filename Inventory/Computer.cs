using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public enum OperatingSystem{
        Linux = 1,
        Windows = 2,
        MacOS = 3
    }
    public class Computer:TechnologicalEquipment
    {
     public OperatingSystem OperatingSystem { get; set; } 
     public bool Portable { get; set; }  

    public Computer(Guid serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, Manufacturer manufacturer, bool containsABattery, OperatingSystem operatingSystem, bool portable)
    :base(serialNumber,description,datePurchased,warrantyInMonths,priceWhenPurchased,manufacturer,containsABattery)
    {
        OperatingSystem = operatingSystem;
        Portable = portable;
    }
    public void PrintComputer()
    {
        decimal price = PriceWhenPurchased;
            decimal price30PercentLess = price - (price * (decimal)0.3);

            DateTime localDate = DateTime.Now;
            TimeSpan result = localDate - DatePurchased;
            var month = result.TotalDays;

            for (int i = 0; i <= month; i++)
            {
                if (price <= price30PercentLess)
                {
                    break;
                }
                else
                {
                    price = price - (price * (decimal)0.05);
                }
            }
        var diffPrice = PriceWhenPurchased - price;
        Console.WriteLine("\n----- Computer -----");
        Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n Contains a battery: {ContainsABattery}\n Operating system: {OperatingSystem}\n Portable: {Portable}");
        Console.WriteLine($" Price now: {Decimal.Round(price)} \n DiffPrice: {Decimal.Round(diffPrice)}");
    
    }
    }
}
