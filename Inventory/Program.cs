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
                foreach (var item in vehicles)
                {
                    System.Console.WriteLine(item.SerialNumber);
                }
                Console.WriteLine("\n------- Inventory -------");
                Console.WriteLine("Input the following number for the desired changes: ");                
                Console.WriteLine("(1) Add a new VEHICLE");
                Console.WriteLine("(2) Add a new COMPUTER");
                Console.WriteLine("(3) Add a new MOBILE PHONE");
                Console.WriteLine("(4) Search by serial number");
                Console.WriteLine("(5) Print all computer whose warranty expire for certain year:");
                Console.WriteLine("(6) Print how many pieces of technological equipment have batteries");
                Console.WriteLine("(7) Search mobile phone by manufacturer");
                Console.WriteLine("(8) Search computer by operating system");
                Console.WriteLine("(9) Print all users of mobile phone whose warranty expire for certain year:");
                Console.WriteLine("(10) Print all vehicles whose license plate expire in the next month:");
                Console.WriteLine("(11) Remove VEHICLE");
                Console.WriteLine("(12) Remove COMPUTER");
                Console.WriteLine("(13) Remove MOBILE PHONE");
                Console.WriteLine("(20) Exit");
                Console.WriteLine("-----------------------------");         
                Console.Write("Input the number: "); inputNumber =Console.ReadLine(); inputNumber.Replace(" ","");


                switch (inputNumber)
                {
                     case "1":
                     {
                        var serialNumber = Guid.NewGuid();
                        Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        Console.Write("License expire year: "); var licenseExpireYear = Console.ReadLine(); licenseExpireYear.Replace(" ","");
                        Console.Write("License expire month: "); var licenseExpireMonth = Console.ReadLine(); licenseExpireMonth.Replace(" ","");
                        Console.Write("License expire day: "); var licenseExpireDay = Console.ReadLine(); licenseExpireDay.Replace(" ","");
                        Console.Write("Mileage: "); var mileage= Console.ReadLine(); mileage.Replace(" ","");

                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 =  Enum.Parse<Manufacturer>(manufacturer);

                        vehicles.Add(new Vehicle(serialNumber,description,datePurchased,int.Parse(warrantyInMonths),int.Parse(priceWhenPurchased),manufacturer2,new DateTime(int.Parse(licenseExpireYear),int.Parse(licenseExpireMonth),int.Parse(licenseExpireDay)),int.Parse(mileage)));
                
                        break;
                     }

                     case "2":
                     {
                        var serialNumber = Guid.NewGuid();
                        Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        Console.Write("Contains a battery (true/false): "); string containsABattery = Console.ReadLine();containsABattery.Replace(" ","");
                        Console.Write("Operating system: "); var operatingSystem = Console.ReadLine(); operatingSystem.Replace(" ","");
                        Console.Write("Portable (true/false): "); string portable = Console.ReadLine();portable.Replace(" ","");

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
                        Console.Write("Description: "); var description = Console.ReadLine(); description.Replace(" ","");
                        DateTime datePurchased = DateTime.Now;
                        Console.Write("Warranty in months: "); var warrantyInMonths = Console.ReadLine(); warrantyInMonths.Replace(" ","");
                        Console.Write("Price: "); var priceWhenPurchased = Console.ReadLine(); priceWhenPurchased.Replace(" ","");
                        Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        Console.Write("Contains a battery (true/false): "); string containsABattery = Console.ReadLine();containsABattery.Replace(" ","");
                        Console.Write("Phone number: "); var phoneNumber = Console.ReadLine(); phoneNumber.Replace(" ","");
                        Console.Write("First name of owner: "); var firstNameOfOwner = Console.ReadLine(); firstNameOfOwner.Replace(" ","");
                        Console.Write("Last name of owner: "); var lastNameOfOwner = Console.ReadLine(); lastNameOfOwner.Replace(" ","");

                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 = Enum.Parse<Manufacturer>(manufacturer);

                        mobilePhones.Add(new MobilePhone(serialNumber,description,datePurchased,int.Parse(warrantyInMonths),int.Parse(priceWhenPurchased),manufacturer2,retrunBool(containsABattery),phoneNumber,firstNameOfOwner,lastNameOfOwner));
                        break;
                        
                     }

                     case "4":
                     {
                        Console.Write("Input serial number: "); var inputSerialNumber =Console.ReadLine(); inputSerialNumber.Replace(" ","");

                        Guid guidSerialNumber = new Guid(inputSerialNumber);
                        SearchBySerialNumber(vehicles,computers,mobilePhones,guidSerialNumber);
                        break;
                        
                     }

                     case "5":
                     {
                        Console.Write("Input year: "); var inputYear =Console.ReadLine(); inputYear.Replace(" ","");

                        foreach (var computer in computers)
                        {
                            if(calculateYearOfWarrantyExpiration(computer,computer.WarrantyInMonths,inputYear) == inputYear)
                            {
                                computer.PrintComputer();
                            }
                        }
                        break;

                        
                     }

                     case "6":
                     {
                        var batteryCounter = 0;
                        foreach (var computer in computers)
                        {
                            if(computer.ContainsABattery == true)
                            {
                                batteryCounter += 1;
                            }
                        }

                        foreach (var phone in mobilePhones)
                        {
                            if(phone.ContainsABattery == true)
                            {
                                batteryCounter += 1;
                            }
                        }
                        Console.WriteLine($"Number of technological equipments with battery:{batteryCounter}");
                        break;
                     }

                     case "7":
                     {
                        Console.Write("Manufacturer: "); var manufacturer = Console.ReadLine(); manufacturer.Replace(" ","");
                        manufacturer = UppercaseFirst(manufacturer);
                        var manufacturer2 =  Enum.Parse<Manufacturer>(manufacturer);

                        foreach (var mobilePhone in mobilePhones)
                        {
                            if (manufacturer2 == mobilePhone.Manufacturer)
                            {
                                mobilePhone.PrintMobilePhone();
                            }
                        }

                        break;
                     }

                     case "8":
                     {
                        Console.Write("Operating system: "); var operatingSystem = Console.ReadLine(); operatingSystem.Replace(" ","");
                        operatingSystem = UppercaseFirst(operatingSystem);
                        var operatingSystem2 = Enum.Parse<OperatingSystem>(operatingSystem);

                        foreach (var computer in computers)
                        {
                            if (operatingSystem2 == computer.OperatingSystem)
                            {
                                computer.PrintComputer();
                            }
                        }

                        break;
                     }

                     case "9":
                     {
                        Console.Write("Input year: "); var inputYear =Console.ReadLine(); inputYear.Replace(" ","");

                        foreach (var mobilePhone in mobilePhones)
                        {
                            if(calculateYearOfWarrantyExpirationForMobilePhone(mobilePhone,mobilePhone.WarrantyInMonths,inputYear) == inputYear)
                            {
                                mobilePhone.PrintUser();
                            }
                        }
                        break;                       
                     }

                     case "10":
                     {

                        DateTime localDate = DateTime.Now;
                        DateTime monthForCheck = localDate.AddMonths(1);
                        TimeSpan result;
                        foreach (var vehicle in vehicles)
                        {
                            result = monthForCheck - vehicle.LicenseExpireDate;
                            if(result.TotalDays < 30 && result.TotalDays > 0)
                            {
                                vehicle.PrintVehicle();
                            }
                        }
                        break;
                        
                     }

                     case "11":
                     {
                        Console.Write("Input serial number: "); var inputSerialNumber =Console.ReadLine(); inputSerialNumber.Replace(" ","");
                        Guid guidSerialNumber = new Guid(inputSerialNumber);
                        foreach (var vehicle in vehicles)
                        {
                            if (guidSerialNumber == vehicle.SerialNumber)
                            {
                                vehicles.Remove(vehicle);
                                break;
                            }
                        }
                         break;
                     }

                     case "12":
                     {
                        Console.Write("Input serial number: "); var inputSerialNumber =Console.ReadLine(); inputSerialNumber.Replace(" ","");
                        Guid guidSerialNumber = new Guid(inputSerialNumber);
                        foreach (var computer in computers)
                        {
                            if (guidSerialNumber == computer.SerialNumber)
                            {
                                computers.Remove(computer);
                                break;
                            }
                        }
                         break;
                     }

                     case "13":
                     {
                        Console.Write("Input serial number: "); var inputSerialNumber =Console.ReadLine(); inputSerialNumber.Replace(" ","");
                        Guid guidSerialNumber = new Guid(inputSerialNumber);
                        foreach (var mobilePhone in mobilePhones)
                        {
                            if (guidSerialNumber == mobilePhone.SerialNumber)
                            {
                                mobilePhones.Remove(mobilePhone);
                                break;
                            }
                        }
                         break;
                     }
               
                }

                
            } while (inputNumber != "20");
       
        }

        static List<Vehicle> AddingVehicles()
        {
            var allVehicles = new List<Vehicle>()
            {
                new Vehicle(Guid.NewGuid(),"Speed car",new DateTime(2018,1,2),60,1000000,Manufacturer.Mercedes,new DateTime(2018,12,20),10000),
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
                new Computer(Guid.NewGuid(),"Desktop Computer", new DateTime(2018,1,20),60,5000,Manufacturer.Asus,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"All-in-One Computer", new DateTime(2018,3,6),24,7000,Manufacturer.Apple,false,OperatingSystem.MacOS,false),
                new Computer(Guid.NewGuid(),"Desktop Computer", new DateTime(2018,12,12),24,5000,Manufacturer.Asus,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"Gaming Computer", new DateTime(2018,4,21),60,10000,Manufacturer.Acer,false,OperatingSystem.Windows,false),
                new Computer(Guid.NewGuid(),"Laptop", new DateTime(2018,10,2),12,5000,Manufacturer.Dell,true,OperatingSystem.Linux,true),
            };
            return allComputers;
        }

        static List<MobilePhone>AddingMobilePhones()
        {
            var allMobilePhones = new List<MobilePhone>()
            {
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2018,10,10),24,2000,Manufacturer.Samsung,true,"0912232223","Ivo","Ivic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2017,1,9),24,4000,Manufacturer.Apple,true,"0982232223","Jure","Juric"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2015,9,24),12,2000,Manufacturer.HTC,true,"0952232223","Ana","Anic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2014,2,3),24,2000,Manufacturer.Samsung,true,"0915555353","Luka","Lulic"),
                new MobilePhone(Guid.NewGuid(), "", new DateTime(2011,7,1),60,2000,Manufacturer.Lenovo,true,"0952314665","Iva","Ivanic")
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

         static void SearchBySerialNumber(List<Vehicle> vehicles, List<Computer> computers, List<MobilePhone> mobilePhones, Guid inputSerialNumber)
         {
            foreach (var item in vehicles)
            {
                if (item.SerialNumber == inputSerialNumber)
                {
                    
                    item.PrintVehicle(); 
                    break;
                }
            }

            foreach (var item in computers)
            {
                if (item.SerialNumber == inputSerialNumber)
                {
                    item.PrintComputer();
                    break;
                }
            }

            foreach (var item in mobilePhones)
            {
                if (item.SerialNumber == inputSerialNumber)
                {
                    item.PrintMobilePhone();
                    break;
                }
            }
            
         }
         static string calculateYearOfWarrantyExpiration(Computer computer, int warrantyInMonths, string inputYear)
         {
             DateTime warrantyExpirationYear = new DateTime();
             switch (warrantyInMonths)
             {
                 case 12:
                 {
                     warrantyExpirationYear = computer.DatePurchased.AddYears(1);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }

                 case 24:
                 {
                     warrantyExpirationYear = computer.DatePurchased.AddYears(2);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }

                 case 60:
                 {
                     warrantyExpirationYear = computer.DatePurchased.AddYears(5);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }
                 
             }
             return "1";
         }

         static string calculateYearOfWarrantyExpirationForMobilePhone(MobilePhone mobilePhone, int warrantyInMonths, string inputYear)
         {
             DateTime warrantyExpirationYear = new DateTime();
             switch (warrantyInMonths)
             {
                 case 12:
                 {
                     warrantyExpirationYear = mobilePhone.DatePurchased.AddYears(1);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }

                 case 24:
                 {
                     warrantyExpirationYear = mobilePhone.DatePurchased.AddYears(2);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }

                 case 60:
                 {
                     warrantyExpirationYear = mobilePhone.DatePurchased.AddYears(5);
                     inputYear = warrantyExpirationYear.Year.ToString();
                     return inputYear;
                     
                 }
                 
             }
             return "1";
         }
    
    }
}
