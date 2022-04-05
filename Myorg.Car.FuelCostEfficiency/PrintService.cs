using Myorg.Car.FuelCostEfficiency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Myorg.Car.FuelCostEfficiency
{
    public class PrintService : IPrintService
    {
        public void PrintData(List<Vehicle> vehicleList, decimal fuelPricePerLiter)
        {
            if (vehicleList != null && vehicleList.Count() > 0)
            {
                //Requirement 1.a, 1.c, 1.d, 1.e
                Console.WriteLine("\nCar fuel cost and fuel efficiency:");
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}", "Vehicle Name", "Litres per km", "Miles per gallon", "Cost per km", "Cost per mile");
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}", "------------", "-------------", "----------------", "-----------", "-------------");
                foreach (var car in vehicleList)
                {
                    Console.WriteLine("{0}\t {1}\t\t {2}\t\t\t {3}\t\t {4}", car.VehicleModel, String.Format("{0:0.00}", car.FuelConsumptionLitresPerKm)
                        , String.Format("{0:0.00}", car.MilesPerGallon)
                        , String.Format("{0:0.00}", car.FuelConsumptionLitresPerKm * fuelPricePerLiter)
                        , String.Format("{0:0.00}", car.FuelConsumptionLitresPerMile * fuelPricePerLiter));
                }
            }
            else
            {
                Console.Write("No data present to print");
            }
        }
    }
}
