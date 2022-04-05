using Myorg.Car.FuelCostEfficiency.Model;
using NUnit.Framework;
using System.Linq;

namespace Myorg.Car.FuelCostEfficiency.TestProject
{
    public class VehicleModelTest
    {
        Vehicle vehicle;
        [SetUp]
        public void Setup()
        {
            vehicle = new Vehicle
            {
                FuelConsumptionPer100Km = 100
            };
        }

        [Test, Order(1)]
        public void FuelConsumptionLitresPerKm_Test()
        {
            Assert.AreEqual(1,vehicle.FuelConsumptionLitresPerKm);            
        }
        [Test, Order(2)]
        public void MilageInKmPerLitre_Test()
        {
            Assert.AreEqual(1, vehicle.MilageInKmPerLitre);
        }
        [Test, Order(3)]
        public void FuelConsumptionLitresPerMile_Test()
        {
            Assert.AreEqual(1.6093440000966945374266097172m, vehicle.FuelConsumptionLitresPerMile);
        }

        [Test, Order(4)]
        public void MilesPerGallon_Test()
        {
            Assert.AreEqual(2.3521458328193690484421583727m, vehicle.MilesPerGallon);
        }
    }
}
