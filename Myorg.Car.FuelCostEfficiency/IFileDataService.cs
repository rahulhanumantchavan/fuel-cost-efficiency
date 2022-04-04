using Myorg.Car.FuelCostEfficiency.Model;
using System.Collections.Generic;

namespace Myorg.Car.FuelCostEfficiency
{
    /// <summary>
    /// IFileDataService
    /// </summary>
    public interface IFileDataService
    {
        /// <summary>
        /// GetVehicles from txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        List<Vehicle> LoadVehicleData(string filePath);
    }
}
