using Myorg.Car.FuelCostEfficiency.Model;
using System.Collections.Generic;

namespace Myorg.Car.FuelCostEfficiency
{
    /// <summary>
    /// IPrintService
    /// </summary>
    public interface IPrintService
    {
        /// <summary>
        /// PrintData
        /// </summary>
        /// <param name="vehicleList"></param>
        /// <param name="fuelPricePerLiter"></param>
        /// <returns></returns>
        void PrintData(List<Vehicle> vehicleList, decimal fuelPricePerLiter);
    }
}
