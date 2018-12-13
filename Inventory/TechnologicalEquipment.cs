using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class TechnologicalEquipment:Product
    {
        private readonly string manufacturer;

        public bool ContainsABattery { get; set; }
        public TechnologicalEquipment(Guid serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, Manufacturer manufacturer, bool containsABattery)
        :base(serialNumber,description,datePurchased,warrantyInMonths,priceWhenPurchased,manufacturer)
        {
            ContainsABattery = containsABattery;
        
        }
    }
    
}
