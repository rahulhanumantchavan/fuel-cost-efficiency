using NUnit.Framework;
using System.Linq;

namespace Myorg.Car.FuelCostEfficiency.TestProject
{
    public class FileDataServiceTests
    {
        FileDataService fileDataService;
        [SetUp]
        public void Setup()
        {
            fileDataService = new FileDataService();
        }

        [Test, Order(1)]
        public void FileNotPresent_Test()
        {
            var ex = Assert.Throws<System.ArgumentException>(() => fileDataService.LoadVehicleData(""));

            Assert.AreEqual("Empty path name is not legal.", ex.Message);
        }
        [Test, Order(2)]
        public void FilePresent_correctFile_Test()
        {
            var res = fileDataService.LoadVehicleData("TestData\\Vehicle Fuel Consumption.txt");
            Assert.IsNotNull(res);
        }
        [Test, Order(3)]
        public void FilePresent_correctFile_withdata_Test()
        {
            var res = fileDataService.LoadVehicleData("TestData\\Vehicle Fuel Consumption.txt");
            Assert.IsTrue(res.Count > 0);
        }
        [Test, Order(4)]
        public void FilePresent_correctFile_withdata_datavalidation_Test()
        {
            var res = fileDataService.LoadVehicleData("TestData\\Vehicle Fuel Consumption.txt");
            Assert.IsTrue(res.Where(x => x.VehicleModel == "Mazda CRX3").Count() > 0);
        }
    }
}