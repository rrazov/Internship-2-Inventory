using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class MobilePhone:TechnologicalEquipment
    {
        public string PhoneNumber { get; set; }
        public string FirstNameOfOwner { get; set; }
        public string LastNameOfOwner { get; set; }

         public MobilePhone(Guid serialNumber, string description, DateTime datePurchased, int warrantyInMonths, decimal priceWhenPurchased, Manufacturer manufacturer, bool containsABattery, string phoneNumber, string firstNameOfOwner, string lastNameOfOwner)
         :base(serialNumber,description,datePurchased,warrantyInMonths,priceWhenPurchased,manufacturer,containsABattery)
         {
             PhoneNumber = phoneNumber;
             FirstNameOfOwner = firstNameOfOwner;
             LastNameOfOwner = lastNameOfOwner;
         }

    }
}
