using System;

namespace Myorg.Car.FuelCostEfficiency
{
    public class ConsoleInputService: IConsoleInputInterface
    {
        public decimal GetFuelPrice()
        {
            //Requirement 1.b
            //Step 1: Input and validate price per litre for the fuel from console
            Console.WriteLine("Please enter the price per litre for the fuel");
            decimal fuelPricePerLiter = 0;
            var consoleResponse = Console.ReadLine();
            if (string.IsNullOrEmpty(consoleResponse))
            {
                Console.WriteLine("Price per litre for the fuel can't be empty! Input again.");
                consoleResponse = Console.ReadLine();
            }
            else
            {
                if (!decimal.TryParse(consoleResponse, out fuelPricePerLiter) || fuelPricePerLiter <= 0)
                {
                    Console.WriteLine("Price per litre for the fuel should be positive int or double! Input again.");
                    consoleResponse = Console.ReadLine();
                    if (!decimal.TryParse(consoleResponse, out fuelPricePerLiter) || fuelPricePerLiter <= 0)
                    {
                        Console.WriteLine("Exceeded maximum retry. Exiting the application.");
                    }
                }
            }
            return fuelPricePerLiter;
        }
    }
}