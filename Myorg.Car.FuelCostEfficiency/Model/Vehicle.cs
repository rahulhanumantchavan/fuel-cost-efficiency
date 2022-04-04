using System;
using System.Collections.Generic;
using System.Text;

namespace Myorg.Car.FuelCostEfficiency.Model
{
    /// <summary>
    /// Vehicle
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// VehicleModel
        /// </summary>
        public string VehicleModel { get; set; }

        /// <summary>
        /// Fuel Consumption Per 100Km
        /// </summary>
        public decimal FuelConsumptionPer100Km { get; set; }

        /// <summary>
        /// Fuel Consumption Litres PerKm
        /// </summary>
        public decimal FuelConsumptionLitresPerKm
        {
            get
            {
                return FuelConsumptionPer100Km / 100;
            }
        }

        /// <summary>
        /// MilageInKmPerLitre
        /// </summary>
        public decimal MilageInKmPerLitre
        {
            get
            {
                return 1 / FuelConsumptionLitresPerKm;
            }
        }

        public decimal FuelConsumptionLitresPerMile
        {
            get
            {
                return FuelConsumptionLitresPerKm * Constants.MilesPerKm;
            }
        }

        public decimal MilesPerGallon
        {
            get
            {
                return MilageInKmPerLitre * Constants.MilesPerKm / Constants.GallonPerLiter;
            }
        }        
    }
}
