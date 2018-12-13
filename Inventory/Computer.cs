using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Computer:TechnologicalEquipment
    {
     public string OperatingSystem { get; set; } 
     public bool Portable { get; set; }  

    public Computer(int serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, string manufacturer, bool containsABattery, string operatingSystem, bool portable)
    :base(serialNumber,description,datePurchased,warrantyInMonths,priceWhenPurchased,manufacturer,containsABattery)
    {
        OperatingSystem = operatingSystem;
        Portable = portable;
    }
    }
}