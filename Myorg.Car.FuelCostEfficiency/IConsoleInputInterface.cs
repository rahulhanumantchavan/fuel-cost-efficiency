using System;
using System.Collections.Generic;
using System.Text;

namespace Myorg.Car.FuelCostEfficiency
{
    /// <summary>
    /// ConsoleInputInterface
    /// </summary>
    public interface IConsoleInputInterface
    {
        /// <summary>
        /// GetFuelPrice
        /// </summary>
        /// <returns></returns>
        public decimal GetFuelPrice();
    }
}
