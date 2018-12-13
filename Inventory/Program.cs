using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = AddingVehicles();
            var computers = AddingComputers();
            var mobilePhones = AddingMobilePhones();

            var inputNumber = "";

            do
            {
                System.Console.WriteLine("\n------- Inventory -------");
                System.Console.WriteLine("Input the following number for the desired changes: ");                
                System.Console.WriteLine("(1) Add a new VEHICLE");
                System.Console.WriteLine("(2) Add a new COMPUTER");
                System.Console.WriteLine("(3) Add a new MOBILE PHONE");
                System.Console.WriteLine("(10) Exit");
                System.Console.WriteLine("-----------------------------");         
                System.Console.Write("Input the number: "); inputNumber =Console.ReadLine(); inputNumber.Replace(" ","");
                
                switch (inputNumber)
                {
                     case "1":
                     {
                        var serialNumber = Guid.NewGuid();
                        System.Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        System.Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        System.Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        System.Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        System.Console.Write("License expire year: "); var licenseExpireYear = Console.ReadLine(); licenseExpireYear.Replace(" ","");
                        System.Console.Write("License expire month: "); var licenseExpireMonth = Console.ReadLine(); licenseExpireMonth.Replace(" ","");
                        System.Console.Write("License expire day: "); var licenseExpireDay = Console.ReadLine(); licenseExpireDay.Replace(" ","");
                        System.Console.Write("Mileage: "); var mileage= Console.ReadLine(); mileage.Replace(" ","");

                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 =  Enum.Parse<Manufacturer>(manufacturer);

                        vehicles.Add(new Vehicle(serialNumber,description,datePurchased,int.Parse(warrantyInMonths),int.Parse(priceWhenPurchased),manufacturer2,new DateTime(int.Parse(licenseExpireYear),int.Parse(licenseExpireMonth),int.Parse(licenseExpireDay)),int.Parse(mileage)));
                
                        break;
                     }

                     case "2":
                     {
                        var serialNumber = Guid.NewGuid();
                        System.Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        System.Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        System.Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        System.Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        System.Console.Write("Contains a battery (true/false): "); string containsABattery = Console.ReadLine();containsABattery.Replace(" ","");
                        System.Console.Write("Operating system: "); var operatingSystem = Console.ReadLine(); operatingSystem.Replace(" ","");
                        System.Console.Write("Portable (true/false): "); string portable = Console.ReadLine();portable.Replace(" ","");

                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 = Enum.Parse<Manufacturer>(manufacturer);

                        operatingSystem = UppercaseFirst(operatingSystem);
                        var operatingSystem2 = Enum.Parse<OperatingSystem>(operatingSystem);

                        computers.Add(new Computer(serialNumber,description,datePurchased,int.Parse(warrantyInMonths),int.Parse(priceWhenPurchased),manufacturer2,retrunBool(containsABattery),operatingSystem2,retrunBool(portable)));
                        break;

                     }

                     case "3":
                     {
                        var serialNumber = Guid.NewGuid();
                        System.Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        System.Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        System.Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        System.Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        System.Console.Write("Contains a battery (true/false): "); string containsABattery = Console.ReadLine();containsABattery.Replace(" ","");
                        System.Console.Write("Phone number: "); var phoneNumber = Console.ReadLine(); phoneNumber.Replace(" ","");
                        System.Console.Write("First name of owner: "); var firstNameOfOwner = Console.ReadLine(); firstNameOfOwner.Replace(" ","");
                        System.Console.Write("Last name of owner: "); var lastNameOfOwner = Console.ReadLine(); lastNameOfOwner.Replace(" ","");

                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 = Enum.Parse<Manufacturer>(manufacturer);

                        mobilePhones.Add(new MobilePhone(serialNumber,description,datePurchased,int.Parse(warrantyInMonths),int.Parse(priceWhenPurchased),manufacturer2,retrunBool(containsABattery),phoneNumber,firstNameOfOwner,lastNameOfOwner));
                        break;
                        
                     }
                    
                }

                
            } while (inputNumber != "10");
       
        }

        static List<Vehicle> AddingVehicles()
        {
            var allVehicles = new List<Vehicle>()
            {
                new Vehicle(Guid.NewGuid(),"Speed car",new DateTime(2018,1,2),60,1000000,Manufacturer.Mercedes,new DateTime(2019,1,2),5000),
                new Vehicle(Guid.NewGuid(),"Family car",new DateTime(1997,9,9),60,200000,Manufacturer.Opel,new DateTime(2020,1,2),350000),
                new Vehicle(Guid.NewGuid(),"Car",new DateTime(1999,10,10),60,300000,Manufacturer.Toyota,new DateTime(2021,10,10),250000),
                new Vehicle(Guid.NewGuid(),"Car",new DateTime(2001,2,2),60,100000,Manufacturer.BMW,new DateTime(2018,6,11),200000),
                new Vehicle(Guid.NewGuid(),"Luxury car",new DateTime(2016,5,19),60,9000000,Manufacturer.Fiat,new DateTime(2017,12,11),70000),

            };
            return allVehicles;
        }

        static List<Computer> AddingComputers()
        {
            var allComputers = new List<Computer>()
            {
                new Computer(Guid.NewGuid(),"Desktop Computer", new DateTime(2018,12,12),24,5000,Manufacturer.Asus,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"All-in-One Computer", new DateTime(2018,10,10),24,7000,Manufacturer.Apple,false,OperatingSystem.MacOS,false),
                new Computer(Guid.NewGuid(),"Desktop Computer", new DateTime(2018,12,12),24,5000,Manufacturer.Asus,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"Gaming Computer", new DateTime(2018,1,1),24,10000,Manufacturer.Acer,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"Laptop", new DateTime(2018,12,12),24,5000,Manufacturer.Dell,true,OperatingSystem.Linux,true),
            };
            return allComputers;
        }

        static List<MobilePhone>AddingMobilePhones()
        {
            var allMobilePhones = new List<MobilePhone>()
            {
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2018,10,10),24,2000,Manufacturer.Samsung,true,"0912232223","Ivo","Ivic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2017,1,9),24,4000,Manufacturer.Apple,true,"0982232223","Jure","Juric"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2016,9,24),24,2000,Manufacturer.HTC,true,"0952232223","Ana","Anic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2015,2,3),24,2000,Manufacturer.Samsung,true,"0915555353","Luka","Lulic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2016,7,1),24,2000,Manufacturer.Lenovo,true,"0952314665","Iva","Ivanic")
            };
            return allMobilePhones;
        }

        static string UppercaseFirst(string x){
            char[] a = x.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        static bool retrunBool(string newString)
        {
         bool yes = true;
         bool no = false;

         if (newString.ToLower() == "true")
         
         {
             return yes;
         }
         return no;
         }
    
    }
}
