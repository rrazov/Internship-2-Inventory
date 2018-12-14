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

         public void PrintMobilePhone()
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

            Console.WriteLine("\n----- Mobile phone -----");
            Console.WriteLine($" Description: {Description}\n Date purchased: {DatePurchased}\n Warranty in months: {WarrantyInMonths}\n Price when purchased: {PriceWhenPurchased}\n Manufacturer: {Manufacturer}\n Contains a battery: {ContainsABattery}\n Phone number: {PhoneNumber}\n First namo of owner: {FirstNameOfOwner}\n First namo of owner: {LastNameOfOwner}");
            Console.WriteLine($" Price now: {Decimal.Round(price)} \n DiffPrice: {Decimal.Round(diffPrice)}");
        }
        public void PrintUser()
        {
            Console.WriteLine("\n----- Mobile phone user-----");
            Console.WriteLine($" Phone number: {PhoneNumber}\n First namo of owner: {FirstNameOfOwner}\n First namo of owner: {LastNameOfOwner}");
        }


    }
}
