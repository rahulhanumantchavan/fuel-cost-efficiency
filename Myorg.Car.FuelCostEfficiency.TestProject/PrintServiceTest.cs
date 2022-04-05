using Myorg.Car.FuelCostEfficiency.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Myorg.Car.FuelCostEfficiency.TestProject
{
    public class PrintServiceTest
    {
        PrintService printService;
        [SetUp]
        public void Setup()
        {
            printService = new PrintService();
        }

        [Test, Order(1)]
        public void EmptyVehicleList_Test()
        {
            List<Vehicle> vehicleList=new List<Vehicle>();
            decimal fuelPricePerLiter = 0;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                printService.PrintData(vehicleList, fuelPricePerLiter);
                string expected = string.Format("No data present to print");
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [Test, Order(2)]
        public void ValidVehicleList_Test()
        {
            var vehicleList = new FileDataService().LoadVehicleData("TestData\\Vehicle Fuel Consumption.txt");
            
            decimal fuelPricePerLiter = 0;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                printService.PrintData(vehicleList, fuelPricePerLiter);
                string expected = string.Format("No data present to print");
                Assert.AreNotEqual(expected, sw.ToString());
            }
        }
    }
}
