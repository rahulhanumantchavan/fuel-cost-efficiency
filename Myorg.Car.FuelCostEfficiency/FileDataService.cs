using Myorg.Car.FuelCostEfficiency.Model;
using System.Collections.Generic;
using System.IO;

namespace Myorg.Car.FuelCostEfficiency
{
    /// <summary>
    /// FileDataService
    /// </summary>
    public class FileDataService : IFileDataService
    {
        /// <summary>
        /// GetVehicles data from txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<Vehicle> LoadVehicleData(string filePath)
        {
            //Step 2: Load data in list
            List<Vehicle> carList = new List<Vehicle>();
            string delimiterChars = ",";
            using (StreamReader sr = new StreamReader(filePath))
            {
                //Ignore the header
                string headerLine = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(delimiterChars);

                    Vehicle vehicle = new Vehicle();
                    vehicle.VehicleModel = words[0];
                    decimal output = 0;
                    decimal.TryParse(words[1].ToString(), out output);
                    vehicle.FuelConsumptionPer100Km = output;
                    carList.Add(vehicle);
                }
            }
            return carList;
        }
    }
}