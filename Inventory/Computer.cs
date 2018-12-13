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
    }
}
