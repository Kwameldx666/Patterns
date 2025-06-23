using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Creational_patterns.Adapter
{
    internal interface IAdapterTemperature
    {
        public double GetTemperatureInFahrenheit(double temperatureInCelsius);
        public double GetTemperatureInKelvin(double temperatureInCelsius);
        public double GetTemperatureInRankine(double temperatureInFahrenheit);
    }
}
