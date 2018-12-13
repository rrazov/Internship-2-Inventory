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
            var mobilePhone = AddingMobilePhones();
        }

        static List<Vehicle> AddingVehicles()
        {
            var allVehicles = new List<Vehicle>()
            {
                new Vehicle(Guid.NewGuid(),"Speed car",new DateTime(2018,1,2),60,1000000,Manufacturer.Mercedes,new DateTime(2019,1,2),5000),
                new Vehicle(Guid.NewGuid(),"Family car",new DateTime(1997,9,9),60,200000,Manufacturer.Opel,new DateTime(2020,1,2),350000),
                new Vehicle(Guid.NewGuid(),"Car",new DateTime(1999,10,10),60,300000,Manufacturer.Toyota,new DateTime(2021,10,10),250000),
                new Vehicle(Guid.NewGuid(),"Car",new DateTime(2001,2,2),60,100000,Manufacturer.Bmw,new DateTime(2018,6,11),200000),
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
    }
}
