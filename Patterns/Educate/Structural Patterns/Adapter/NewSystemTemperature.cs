using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Creational_patterns.Adapter
{
    internal class NewSystemTemperature : IAdapterTemperature
    {
        private readonly Celsia _temperature;
        public NewSystemTemperature(Celsia temperature)
        {
            _temperature = temperature;
        }

        public double GetTemperatureInFahrenheit(double temperatureInCelsius)
        {
            Console.WriteLine("Converting temperature from Celsius to Fahrenheit using the new system adapter.");
            return _temperature.ShowTemperatureInCelsia(temperatureInCelsius) * 9 / 5 + 32;
        }

        public double GetTemperatureInKelvin(double temperatureInCelsius)
        {
         
            Console.WriteLine("Converting temperature from Celsius to Kelvin using the new system adapter.");
            return _temperature.ShowTemperatureInCelsia(temperatureInCelsius) + 273.15;
        }

        public double GetTemperatureInRankine(double temperatureInCelsius)
        {
          
            Console.WriteLine("Converting temperature from Celsius to Rankine using the new system adapter.");
            return (_temperature.ShowTemperatureInCelsia(temperatureInCelsius) + 273.15) * 9 / 5 + 491.67;
        }
    }
}
