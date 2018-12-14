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
    public void PrintBySerialNumber()
        {
            Console.WriteLine("----- Computer -----");
            Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n Contains a battery: {ContainsABattery}\n Operating system: {OperatingSystem}\n Portable: {Portable}");
        }

    }
}
