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

         public void PrintBySerialNumber()
        {
            Console.WriteLine("----- Mobile phone -----");
            Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n Contains a battery: {ContainsABattery}\n Phone number: {PhoneNumber}\n First namo of owner: {FirstNameOfOwner}\n First namo of owner: {LastNameOfOwner}\n");
        }

        public void PrintUser()
        {
            Console.WriteLine("----- Mobile phone user-----");
            Console.WriteLine($" Phone number: {PhoneNumber}\n First namo of owner: {FirstNameOfOwner}\n First namo of owner: {LastNameOfOwner}\n");
        }


    }
}
