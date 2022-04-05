using System;

namespace Myorg.Car.FuelCostEfficiency
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleInputService consoleInputService = new ConsoleInputService();
            decimal fuelPricePerLiter = consoleInputService.GetFuelPrice();
            if (fuelPricePerLiter <= 0)
            {
                Console.WriteLine("Exceeded maximum retry. Exiting the application.");
            }
            else
            {
                FileDataService fileDataService = new FileDataService();
                try
                {
                    string filePath = "TestData\\Vehicle Fuel Consumption.txt";
                    var vehicleList = fileDataService.LoadVehicleData(filePath);

                    PrintService printService = new PrintService();
                    printService.PrintData(vehicleList, fuelPricePerLiter);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occured. Exception details {ex.Message}");
                }
            }
        }
    }
}