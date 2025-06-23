using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Creational_patterns.Adapter
{
    internal class Celsia
    {
        public double ShowTemperatureInCelsia(double temperatureInCelsius)
        {
            Console.WriteLine("Temperature is: " + temperatureInCelsius + "°C");
            return temperatureInCelsius;
        }
    }
}
